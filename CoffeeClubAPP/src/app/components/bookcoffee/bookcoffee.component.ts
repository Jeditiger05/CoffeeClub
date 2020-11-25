import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Bookings } from 'src/app/models/bookings';
import { DataService } from 'src/app/services/data.service';

@Component({
  selector: 'app-bookcoffee',
  templateUrl: './bookcoffee.component.html',
  styleUrls: ['./bookcoffee.component.css']
})
export class BookcoffeeComponent implements OnInit {

  constructor(private dataService: DataService, private router: Router) { }

  ngOnInit(): void {
  }

  bookCoffee(form){
    let newBooking = {
      bookingDate: form.value['bookingdate'],
      name: this.dataService.member.value.name,
      venue: form.value['venue'],
      memberId: this.dataService.member.value.memberId
    }

    console.log(newBooking);

    this.dataService.bookCoffee(newBooking).then(() => {
      console.log("Coffee Date Booked");
      alert("Coffee Date Booked");
      this.router.navigate(['']);
    }).catch(() => {
      console.error("Booking Failed");
    }).finally(() => {
      console.log("Booking Finalized");
    });
  }
}
