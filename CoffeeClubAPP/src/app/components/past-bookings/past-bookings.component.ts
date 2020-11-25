import { Component, OnInit } from '@angular/core';
import { Bookings } from 'src/app/models/bookings';
import { DataService } from 'src/app/services/data.service';

@Component({
  selector: 'app-past-bookings',
  templateUrl: './past-bookings.component.html',
  styleUrls: ['./past-bookings.component.css']
})
export class PastBookingsComponent implements OnInit {

  bookings: Bookings[];
  bookingNumber: number;
  booking: Bookings;
  members: string[];
  
  constructor(private dataService: DataService) { 
    this.getPastBookings();
    dataService.getMembersList().then((res: string[]) => {
      this.members = res;
    })
  }

  ngOnInit(): void {
  }

  getPastBookings(){
    this.dataService.getPastBookings().then((res: Bookings[]) => {
      this.bookings = res;
      console.log("Bookings Received");
    }).catch(() => {
      console.error("List Bookings Failed");
    }).finally(() => {
      console.log("List Bookings Finalized");
    });
  }

  updateBooking(form){
    this.booking = this.bookings.find(b => b.bookingNumber == form.value['bookingNumber']);

    let updatedBooking: Bookings = {
      bookingNumber: form.value['bookingNumber'],
      bookingDate: this.booking.bookingDate,
      name: this.booking.name,
      shoutee: form.value['shoutee'],
      amountShouted: form.value['amountShouted'],
      venue: this.booking.venue,
      memberId: this.dataService.member.value.memberId
    }

    console.log(updatedBooking);
    
    this.dataService.updateBooking(updatedBooking).then(() => {
      console.log("Booking Updated");
      alert("Booking Updated Successfully");
      this.getPastBookings();
    }).catch(() => {
      console.error("Update Failed");
    }).finally(() => {
      console.log("Update Finalized");
    });
  }

}
