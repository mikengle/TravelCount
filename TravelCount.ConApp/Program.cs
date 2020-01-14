using System;
using System.Threading.Tasks;

namespace TravelCount.ConApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello TravelCount!");

            using var ctrlTravel = Logic.Factory.CreateTravelController();

            var travel = await ctrlTravel.CreateAsync();

            travel.Designation = "Karibik 2020";
            travel.Category = "Reisen";
            travel.Currency = "EUR";
            travel.Friends = "Michi,Flo";
            travel = await ctrlTravel.InsertAsync(travel);
            await ctrlTravel.SaveChangesAsync();

            using var ctrlExpense = Logic.Factory.CreateExpenseController(ctrlTravel);

            var expense = await ctrlExpense.CreateAsync();
            expense.TravelId = travel.Id;
            // expense.Date = DateTime.Now;
            expense.Amount = 100;
            expense.Description = "Essen";
            expense.Friend = "Flo;Michi";
            expense = await ctrlExpense.InsertAsync(expense);
            await ctrlExpense.SaveChangesAsync();

        }
    }
}
