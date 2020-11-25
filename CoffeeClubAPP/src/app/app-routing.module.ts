import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BookcoffeeComponent } from './components/bookcoffee/bookcoffee.component';
import { BookingsComponent } from './components/bookings/bookings.component';
import { LoginComponent } from './components/login/login.component';
import { PastBookingsComponent } from './components/past-bookings/past-bookings.component';
import { RegisterComponent } from './components/register/register.component';
import { AuthGuard } from './guards/auth.guard';

const routes: Routes = [
  {path: "register", component: RegisterComponent},
  {path: "login", component: LoginComponent},
  {path: "book-coffee", component: BookcoffeeComponent, canActivate: [AuthGuard]},
  {path: "future-bookings", component: BookingsComponent, canActivate: [AuthGuard]},
  {path: "past-bookings", component: PastBookingsComponent, canActivate: [AuthGuard]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
