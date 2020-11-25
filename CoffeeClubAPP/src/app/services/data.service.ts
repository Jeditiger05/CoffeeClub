import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Bookings } from '../models/bookings';
import { Login } from '../models/login';
import { Member } from '../models/member';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  apiURL = "https://localhost:5001/api";
  member: BehaviorSubject<Member>;

  constructor(private _http: HttpClient) { 
    this.member = new BehaviorSubject(null);
  }

  login(login: Login) {
    return new Promise((resolve, reject) => {
      this._http.post(this.apiURL + "/members/memberlogin", login).subscribe(
        res => {
          console.log(res);
          resolve(res);
        },
        err => {
          console.log(err);
          reject(err);
        });
    });
  }

  register(member: Member) {
    return new Promise((resolve, reject) => {
      this._http.post(this.apiURL + "/members/registermember", member).subscribe(
        res => {
          console.log(res);
          resolve(res);
        },
        err => {
          console.log(err);
          reject(err);
        });
    });
  }

  bookCoffee(booking) {
    return new Promise((resolve, reject) => {
      this._http.post(this.apiURL + "/members/bookcoffee", booking).subscribe(
        res => {
          console.log(res);
          resolve(res);
        },
        err => {
          console.log(err);
          reject(err);
        });
    });
  }

  getBookings() {
    return new Promise((resolve, reject) => {
      this._http.get<Bookings>(this.apiURL + "/members/getbookings").subscribe(
        res => {
          console.log(res);
          resolve(res);
        },
        err => {
          console.log(err);
          reject(err);
        });
    });
  }

  getMembersList() {
    return new Promise((resolve, reject) => {
      this._http.get<string[]>(this.apiURL + "/members/getallmembers").subscribe(
        res => {
          console.log(res);
          resolve(res);
        },
        err => {
          console.log(err);
          reject(err);
        });
    });
  }

  getPastBookings() {
    return new Promise((resolve, reject) => {
      this._http.get<Bookings>(this.apiURL + "/members/getpastbookings").subscribe(
        res => {
          console.log(res);
          resolve(res);
        },
        err => {
          console.log(err);
          reject(err);
        });
    });
  }

  deleteBooking(bookingNumber) {
    return new Promise((resolve, reject) => {
      this._http.delete(this.apiURL + "/members/deletebooking?bookingNumber=" + bookingNumber).subscribe(
        res => {
          console.log(res);
          resolve(res);
        },
        err => {
          console.log(err);
          reject(err);
        });
    });
  }

  updateBooking(booking) {
    return new Promise((resolve, reject) => {
      this._http.post(this.apiURL + "/members/updatebooking", booking).subscribe(
        res => {
          console.log(res);
          resolve(res);
        },
        err => {
          console.log(err);
          reject(err);
        });
    });
  }
}
