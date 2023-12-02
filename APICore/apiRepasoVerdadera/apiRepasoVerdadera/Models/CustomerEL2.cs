using System.ComponentModel.DataAnnotations;
using apiRepasoVerdadera.Data;
using Microsoft.EntityFrameworkCore;

namespace apiRepasoVerdadera.Models
{
    public class CustomerEL2
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Address { get; set; }
        
    }


public static class CustomerEL2Endpoints
{
	public static void MapCustomerEL2Endpoints (this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/CustomerEL2", async (apiRepasoVerdaderaContext db) =>
        {
            return await db.CustomerEL2.ToListAsync();
        })
        .WithName("GetAllCustomerEL2s")
        .Produces<List<CustomerEL2>>(StatusCodes.Status200OK);

        routes.MapGet("/api/CustomerEL2/{id}", async (int Id, apiRepasoVerdaderaContext db) =>
        {
            return await db.CustomerEL2.FindAsync(Id)
                is CustomerEL2 model
                    ? Results.Ok(model)
                    : Results.NotFound();
        })
        .WithName("GetCustomerEL2ById")
        .Produces<CustomerEL2>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);

        routes.MapPut("/api/CustomerEL2/{id}", async (int Id, CustomerEL2 customerEL2, apiRepasoVerdaderaContext db) =>
        {
            var foundModel = await db.CustomerEL2.FindAsync(Id);

            if (foundModel is null)
            {
                return Results.NotFound();
            }

            db.Update(customerEL2);

            await db.SaveChangesAsync();

            return Results.NoContent();
        })
        .WithName("UpdateCustomerEL2")
        .Produces(StatusCodes.Status404NotFound)
        .Produces(StatusCodes.Status204NoContent);

        routes.MapPost("/api/CustomerEL2/", async (CustomerEL2 customerEL2, apiRepasoVerdaderaContext db) =>
        {
            db.CustomerEL2.Add(customerEL2);
            await db.SaveChangesAsync();
            return Results.Created($"/CustomerEL2s/{customerEL2.Id}", customerEL2);
        })
        .WithName("CreateCustomerEL2")
        .Produces<CustomerEL2>(StatusCodes.Status201Created);


        routes.MapDelete("/api/CustomerEL2/{id}", async (int Id, apiRepasoVerdaderaContext db) =>
        {
            if (await db.CustomerEL2.FindAsync(Id) is CustomerEL2 customerEL2)
            {
                db.CustomerEL2.Remove(customerEL2);
                await db.SaveChangesAsync();
                return Results.Ok(customerEL2);
            }

            return Results.NotFound();
        })
        .WithName("DeleteCustomerEL2")
        .Produces<CustomerEL2>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);
    }
}}
