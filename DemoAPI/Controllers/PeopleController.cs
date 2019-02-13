using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
	/// <summary>
	/// This is where i gave you all the information about my peeps.
	/// </summary>
	public class PeopleController : ApiController
	{
		List<Person> people = new List<Person>();

		public PeopleController()
		{
			people.Add(new Person { FirstName = "Camilo", LastName = "Gomez", Id = 1 });
			people.Add(new Person { FirstName = "Juan", LastName = "Galindo", Id = 2 });
			people.Add(new Person { FirstName = "Pedro", LastName = "Jimenez", Id = 3 });
		}

		/// <summary>
		/// Gets a list of the first names of all the users
		/// </summary>
		/// <param name="userId">The unique identifier for this person</param>
		/// <param name="age">We want to know how old they are</param>
		/// <returns>A list of first names</returns>
		[Route("api/people/getfirstnames/{userId:int}/{age:int}")]
		[HttpGet]
		public List<string> GetFirstNames(int userId, int age)
		{
			List<string> output = new List<string>();
			foreach (var p in people)
			{
				output.Add(p.FirstName);
			}
			return output;
		}

		// GET: api/People
		public List<Person> Get()
		{
			return people;
		}

		// GET: api/People/5
		public Person Get(int id)
		{
			return people.SingleOrDefault(x => x.Id == id);
		}

		// POST: api/People
		public void Post(Person val)
		{
			people.Add(val);
		}

		// PUT: api/People/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE: api/People/5
		public void Delete(int id)
		{
		}
	}
}
