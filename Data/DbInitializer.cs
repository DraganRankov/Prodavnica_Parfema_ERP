using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(StoreContext context, UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new User
                {
                    UserName = "bob",
                    Email = "bob@test.com"
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");

                var admin = new User
                {
                    UserName = "admin",
                    Email = "admin@test.com"
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] {"Member", "Admin"});
            }
            

            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Channel Allure Homme Edition Blanche 100ml edp",
                    Description =
                        "Nova verzija slavnog muškog Chanel Allure Homme parfema, stiže u raskošnom i luksuznom izdanju u elegantnoj, jednostavnoj svetloj bočici. U istoriji Chanel kuće bela boja je igrala značajnu ulogu.",
                    Price = 20000,
                    PictureUrl = "/images/products/IMG_7771.jpg",
                    Brand = "Channel",
                    Type = "muški",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Armani Acqua Di Gio Profumo 50ml edp",
                    Description = "Acqua di Gio Profumo je vodena, drvena i začinska kompozicija koju, kao i original, potpisuje Alberto Morillas. Otvara se svežim vodenim akordom i bergamotom. U srcu su aromatični tonovi geraniuma, žalfije i ružmarina, položeni na bazu pačulija i tamjana.",
                    Price = 15000,
                    PictureUrl = "/images/products/IMG_7772.jpg",
                    Brand = "Armani",
                    Type = "muški",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Givenchy Gentleman Cologne 100ml edt",
                    Description =
                        "Gentleman Cologne od Givenchy je drveni aromatični miris za muškarce. Gentleman Cologne je predstavljen 2019. Gentleman Cologne je kreirao Nathalie Lorson i Olivier Cresp. Gornje note su Bergamot, Limun i Petit grain; srednje note su Iris, vetiver i Ruzmarin; bazne note su Ambroksan i mošus.",
                    Price = 18000,
                    PictureUrl = "/images/products/IMG_7774.jpg",
                    Brand = "Givenchy",
                    Type = "muški",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Hermès Un Jardin Sur La Lagune",
                    Description =
                        "Un Jardin Sur La Lagune od Hermès je amber cvetni miris za žene i muškarce. Un Jardin Sur La Lagune je predstavljen 2019. Parfem je kreirao Christine Nagel.",
                    Price = 30000,
                    PictureUrl = "/images/products/IMG_7776.jpg",
                    Brand = "Hermès",
                    Type = "unisex",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "This is Us! L'Eau for All Zadig & Voltaire 50ml edp",
                    Description =
                        "This is Us! L'Eau for All od Zadig & Voltaire je drveni aromatični miris za žene i muškarce. Ovo je novi parfem. This is Us! L'Eau for All je predstavljen 2022. Gornja nota je Bergamot; srednje note su lavanda i Neroli; bazne note su Cashmeran, Sandalovo drvo i mošus.",
                    Price = 25000,
                    PictureUrl = "/images/products/IMG_7976.jpg",
                    Brand = "Zadig & Voltaire",
                    Type = "unisex",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Bvlgari Aqva Pour Homme 100ml edt",
                    Description =
                        "Aqva Pour Homme od Bvlgari je aromatični vodeni miris za muškarce. Aqva Pour Homme je predstavljen 2005. Parfem je kreirao Jacques Cavallier. Gornje note su Mandarina, Narandža i Petit grain; srednje note su Morska trava, lavanda i Cvet pamuka; bazne note su Kedar iz Virdžinije, Drvene note, pačuli, Muškatna žalfija i Amber.",
                    Price = 12000,
                    PictureUrl = "/images/products/IMG_7978.jpg",
                    Brand = "Bvlgari",
                    Type = "muški",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Chanel Chance Eau Tendre 50ml edp",
                    Description =
                        "Chance Eau Tendre od Chanel je cvjetni voćni miris za žene. Chance Eau Tendre je predstavljen 2010. Parfem je kreirao Jacques Polge. Gornje note su Dunja i Grejpfrut; srednje note su Zumbul i jasmin; bazne note su mošus, Iris, Kedar iz Virdžinije i Amber.",
                    Price = 1000,
                    PictureUrl = "/images/products/IMG_7980.jpg",
                    Brand = "Chanel",
                    Type = "ženski",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Versace Bright Crystal 50ml edt",
                    Description =
                        "Bright Crystal od Versace je cvetni voćni miris za žene. Bright Crystal je predstavljen 2006. Parfem je kreirao Alberto Morillas. Gornje note su Yuzu, nar i Led; srednje note su Božur, Lotus i Magnolija; bazne note su mošus, Mahogonij i Amber.",
                    Price = 8000,
                    PictureUrl = "/images/products/IMG_7984.jpg",
                    Brand = "Versace",
                    Type = "ženski",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Tom Ford Soleil Blanc 75ml edp",
                    Description =
                        "Soleil Blanc od Tom Ford je amber cvjetni miris za žene i muškarce. Soleil Blanc je predstavljen 2016. Parfem je kreirao Natalie Gracia-Cetto. Gornje note su Pistaći, Bergamot, Kardamon i Ružičasti biber; srednje note su Tuberoza, Ylang-Ylang i jasmin; bazne note su Kokos, Amber, Mahune Tonke i Benzoin.",
                    Price = 1500,
                    PictureUrl = "/images/products/IMG_8010.jpg",
                    Brand = "Tom Ford",
                    Type = "unisex",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Xerjoff Erba Pura 75ml edp",
                    Description =
                        "Erba Pura od Xerjoff je amber miris za žene i muškarce. Erba Pura je predstavljen 2019. Erba Pura je kreirao Christian Carbonnel i Laura Santander. Gornje note su Sicilijanska narandža, bergamot i Sicilijanski limun; srednja nota je Voćne note; bazne note su Bijeli mošus, vanilija sa Madagaskara i Amber.",
                    Price = 1800,
                    PictureUrl = "/images/products/IMG_8010.jpg",
                    Brand = "Xerjoff",
                    Type = "unisex",
                    QuantityInStock = 100
                },
               
            };
            
            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}