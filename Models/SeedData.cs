using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BugrahanDurukan_HW2.Models
{
	/*
	 SeedData: To populate the database and provide some sample data
	 */
	public class SeedData
	{
		/*
		 IApplicationBuilder argument, which is the interface used in the 
		 Configure method of the Startup class to register middleware 
		 components to handle HTTP requests. 
		 IApplicationBuilder also provides access to the application’s 
		 services, including the Entity Framework Core database 
		 context service
		 */
		public static void EnsurePopulated(IApplicationBuilder app)
		{
			MagazineDBContext context = app.ApplicationServices.CreateScope().
										ServiceProvider.GetRequiredService<MagazineDBContext>();
			if (!context.Magazines.Any())
			{
				context.Magazines.AddRange(
				new Magazine
				{
					Name = "seventeen",
					Description = "a magazine for youth",
					Category = "Youth",
					Price = 275
				},
				new Magazine
				{
					Name = "Brand",
					Description = "Fashion Magazine",
					Category = "Fashion",
					Price = 48.95m
				},
				new Magazine
				{
					Name = "Soccer",
					Description = "Football magazine",
					Category = "Sports",
					Price = 19.50m
				},
				new Magazine
				{
					Name = "Man's Health",
					Description = "A fitness magazine ",
					Category = "Health",
					Price = 34.95m
				},
				new Magazine
				{
					Name = "Stadium",
					Description = "A Football magazine",
					Category = "Sports",
					Price = 79500
				},
				 new Magazine
				 {
					 Name = "Think",
					 Description = "A magazine to gve you new perspective",
					 Category = "Creative",
					 Price = 16
				 },
				 new Magazine
				 {
					 Name = "Forever Sports",
					 Description = "Wellness and sports magazine",
					 Category = "Wellness",
					 Price = 29.95m
				 },
				 new Magazine
				 {
					 Name = "Outdoor",
					 Description = "A nature magazine",
					 Category = "Nature",
					 Price = 75
				 },
				 new Magazine
				 {
					 Name = "Nat geo",
					 Description = "A magazine made by national geographic",
					 Category = "Science",
					 Price = 1200
				 }
				 );
				context.SaveChanges();
			}
			if (!context.Novels.Any())
			{
				context.Novels.AddRange(
				new Novel
				{
					Name = "Anna Karenina",
					Description = "adultery, gambling, marriage plots, and, well, Russian feudalism",
					Category = "Classics",
					Price = 275
				},
				new Novel
				{
					Name = "To Kill a Mockingbird",
					Description = "became an immediate classic of literature",
					Category = "Classics",
					Price = 48.95m
				},
				new Novel
				{
					Name = "The Great Gatsby",
					Description = "The Great Gatsby is distinguished as one of the greatest texts for introducing students to the art of reading",
					Category = "Historical",
					Price = 19.50m
				},
				new Novel
				{
					Name = "One Hundred Years of Solitude",
					Description = "The novel tells the story of seven generations of the Buendía family",
					Category = "Historical",
					Price = 34.95m
				},
				new Novel
				{
					Name = "A Passage to India",
					Description = "A Passage to India after multiple trips to the country throughout",
					Category = "Historical",
					Price = 79500
				},
				 new Novel
				 {
					 Name = "Invisible Man",
					 Description = "Wells’s science-fiction novella of nearly the same name",
					 Category = "Biography",
					 Price = 16
				 },
				 new Novel
				 {
					 Name = "Don Quixote",
					 Description = "perhaps the most influential and well-known work of Spanish literature",
					 Category = "Literature",
					 Price = 29.95m
				 },
				 new Novel
				 {
					 Name = "Beloved",
					 Description = "spiritual and haunting novel",
					 Category = "Biography",
					 Price = 75
				 },
				 new Novel
				 {
					 Name = "Mrs. Dalloway",
					 Description = "Possibly the most idiosyncratic novel",
					 Category = "Biography",
					 Price = 1200
				 }
				 );
				context.SaveChanges();
			}
		}
	}
}
