import { Component, OnInit } from '@angular/core';
import { Bookings } from 'src/app/models/bookings';
import { DataService } from 'src/app/services/data.service';

@Component({
  selector: 'app-bookings',
  templateUrl: './bookings.component.html',
  styleUrls: ['./bookings.component.css']
})
export class BookingsComponent implements OnInit {

  bookings: Bookings;
  bookingNumber: number;

  constructor(private dataService: DataService) {
    this.getBookings();
  }

  ngOnInit(): void {
  }

  getBookings() {
    this.dataService.getBookings().then((res: Bookings) => {
      this.bookings = res;
      console.log("Bookings Received");
    }).catch(() => {
      console.error("List Bookings Failed");
    }).finally(() => {
      console.log("List Bookings Finalized");
    });
  }

  deleteBooking() {
    console.log(this.bookingNumber);
    this.dataService.deleteBooking(this.bookingNumber).then(() => {
      console.log("Booking Deleted");
      alert("Booking Deleted Successfully")
      this.getBookings();
    }).catch(() => {
      console.error("Delete Failed");
    }).finally(() => {
      console.log("Delete Finalized");
    });
  }
}
