using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoffeeClubAPI.Models;

namespace CoffeeClubAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : Controller
    {
        private readonly CoffeeClubDBContext _context;

        public MembersController(CoffeeClubDBContext context)
        {
            _context = context;
        }

        //Memeber Login
        [HttpPost, Route("memberlogin")]
        public async Task<IActionResult> Login(Login login)
        {
            var member = await _context.Member.Where(m => m.Email == login.Email).FirstOrDefaultAsync();

            if(member != null)
            {
                if(member.Pending == true)
                {
                    return Unauthorized("Account Pending");
                }
                else if (member.Password == login.Password)
                {
                    return Ok(member);
                }
                else
                {
                    return Unauthorized();
                }
            }
            else
            {
                return NotFound();
            }
        }

        //Register Member
        [HttpPost, Route("registermember")]
        public async Task<IActionResult> RegisterMember(Member member)
        {
            try
            {
                _context.Add(member);
                await _context.SaveChangesAsync();
                return Ok(member);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Create a Coffee Booking
        [HttpPost, Route("bookcoffee")]
        public async Task<IActionResult> CreateBooking(Booking booking)
        {
            try
            {
                _context.Add(booking);
                await _context.SaveChangesAsync();
                return Ok(booking);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Return All Furture Bookings
        [HttpGet, Route("getbookings")]
        public async Task<IActionResult> GetBookings()
        {
            var bookings = await _context.Booking.Where(b => b.BookingDate > DateTime.Now).ToListAsync();

            if (bookings != null)
            {
                return Ok(bookings);

            }
            else
            {
                return NotFound();
            }

        }

        //Return All Past Bookings
        [HttpGet, Route("getpastbookings")]
        public async Task<IActionResult> GetPastBookings()
        {
            var bookings = await _context.Booking.Where(b => b.BookingDate < DateTime.Now).ToListAsync();

            if (bookings != null)
            {
                return Ok(bookings);

            }
            else
            {
                return NotFound();
            }

        }

        //Update a Coffee Booking
        [HttpPost, Route("updatebooking")]
        public async Task<IActionResult> UpdateBooking(Booking booking)
        {
            try
            {
                _context.Booking.Update(booking);
                await _context.SaveChangesAsync();
                return Ok(booking);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Delete a Coffee Booking
        [HttpDelete, Route("deletebooking")]
        public async Task<IActionResult> DeleteBooking(int bookingNumber)
        {
            var booking = await _context.Booking.Where(b => b.BookingNumber == bookingNumber).FirstOrDefaultAsync();

            try
            {
                _context.Remove(booking);
                await _context.SaveChangesAsync();
                return Ok(bookingNumber);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Return All Members and Total shout cost
        [HttpGet, Route("getallmembers")]
        public async Task<IActionResult> GetAllMembers()
        {
            var memebers = await _context.Member.Where(m => m.Pending == false).Select(m => m.Name).ToListAsync();

            if (memebers != null)
            {
                return Ok(memebers);

            }
            else
            {
                return NotFound();
            }

        }
    }
}
