using Microsoft.AspNetCore.Mvc;
using Project_1___Bakkerij.Models;

namespace Project_1___Bakkerij.Controllers
{
    public class AdminController : Controller
    {
        // Aanpassen van productprijzen
        public IActionResult UpdateProductPrices()
        {
            // Haal hier de producten op uit de database
            var products = GetProductsFromDatabase();
            return View(products);
        }

        [HttpPost]
        public IActionResult UpdateProductPrices(List<ProductModel> products)
        {
            // Verwerk hier de bijgewerkte prijzen en sla ze op in de database
            UpdateProductPricesInDatabase(products);
            return RedirectToAction("ProductList");
        }

        // Administrator aanmaken of verwijderen
        public IActionResult ManageAdministrators()
        {
            // Haal hier alle administrators op uit de database
            var administrators = GetAdministratorsFromDatabase();
            return View(administrators);
        }

        [HttpPost]
        public IActionResult CreateAdministrator(AdminModel administrator)
        {
            // Maak hier een nieuwe administrator aan en sla deze op in de database
            CreateAdministratorInDatabase(administrator);
            return RedirectToAction("ManageAdministrators");
        }

        [HttpPost]
        public IActionResult DeleteAdministrator(int adminId)
        {
            // Verwijder hier de geselecteerde administrator uit de database
            DeleteAdministratorFromDatabase(adminId);
            return RedirectToAction("ManageAdministrators");
        }

        // Gebruiker goedkeuren door administrator
        public IActionResult ApproveUser()
        {
            // Haal hier alle gebruikers op die goedgekeurd moeten worden
            var unapprovedUsers = GetUnapprovedUsersFromDatabase();
            return View(unapprovedUsers);
        }

        [HttpPost]
        public IActionResult ApproveUser(int userId)
        {
            // Keur hier de geselecteerde gebruiker goed en sla deze wijziging op in de database
            ApproveUserInDatabase(userId);
            return RedirectToAction("ApproveUser");
        }

        // Voeg hier de methoden toe om gegevens uit de database op te halen en te bewerken
        private List<ProductModel> GetProductsFromDatabase() 
        {
            return new List<ProductModel>();
        }
        private void UpdateProductPricesInDatabase(List<ProductModel> products) 
        {

        }
        private List<AdminModel> GetAdministratorsFromDatabase() 
        {
            return new List<AdminModel>();
        }
        private List<UserModel> GetUnapprovedUsersFromDatabase()
        {
            // Simulatie van het ophalen van niet-goedgekeurde gebruikers uit de database
            return new List<UserModel>();
        }

        private void ApproveUserInDatabase(int userId)
        {
            // Simulatie van het goedkeuren van een gebruiker in de database
        }

        private void CreateAdministratorInDatabase(AdminModel administrator)
        {
            // Simulatie van het aanmaken van een administrator in de database
        }

        private void DeleteAdministratorFromDatabase(int adminId)
        {
            // Simulatie van het verwijderen van een administrator uit de database
        }
    }
}
