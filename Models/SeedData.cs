using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models {

    public static class SeedData {

        public static void EnsurePopulated(IApplicationBuilder app) {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any()) {
                context.Database.Migrate();
            }

            if (!context.Products.Any()) {
                context.Products.AddRange(
                    new Product {
                        İcerik = "Ege Denizi'nde 4,2 büyüklüğünde deprem meydana geldi.Afet ve Acil Durum Yönetimi Başkanlığının internet sitesinde yer alan bilgiye göre, saat 01.31'de, Ege Denizi'nin Yunanistan açıklarında 4,2 büyüklüğünde deprem kaydedildi.Deniz yüzeyinin 12,50 kilometre derinliğindeki depremin merkez üssünün Yunanistan'a 13,80 kilometre, Çanakkale'nin Gökçeada ilçesine ise 114,11 kilometre mesafede olduğu belirlendi.",
                        Category = "Güncel",
                        Ozet = "Ege Denizi'nde 4,2 büyüklüğünde deprem meydana geldi.",
                        ResimYol ="/img/deprem.jpg"
                    },
                    new Product {
                        İcerik = "Ege Denizi'nde 4,2 büyüklüğünde deprem meydana geldi.Afet ve Acil Durum Yönetimi Başkanlığının internet sitesinde yer alan bilgiye göre, saat 01.31'de, Ege Denizi'nin Yunanistan açıklarında 4,2 büyüklüğünde deprem kaydedildi.Deniz yüzeyinin 12,50 kilometre derinliğindeki depremin merkez üssünün Yunanistan'a 13,80 kilometre, Çanakkale'nin Gökçeada ilçesine ise 114,11 kilometre mesafede olduğu belirlendi.",
                        Category = "Güncel",
                        Ozet = "Ege Denizi'nde 4,2 büyüklüğünde deprem meydana geldi.",
                        ResimYol = "/img/deprem.jpg"
                    },
                    new Product {
                        İcerik = "Ege Denizi'nde 4,2 büyüklüğünde deprem meydana geldi.Afet ve Acil Durum Yönetimi Başkanlığının internet sitesinde yer alan bilgiye göre, saat 01.31'de, Ege Denizi'nin Yunanistan açıklarında 4,2 büyüklüğünde deprem kaydedildi.Deniz yüzeyinin 12,50 kilometre derinliğindeki depremin merkez üssünün Yunanistan'a 13,80 kilometre, Çanakkale'nin Gökçeada ilçesine ise 114,11 kilometre mesafede olduğu belirlendi.",
                        Category = "Güncel",
                        Ozet = "Ege Denizi'nde 4,2 büyüklüğünde deprem meydana geldi.",
                        ResimYol = "/img/deprem.jpg"
                    },
                    new Product {
                        İcerik = "Ege Denizi'nde 4,2 büyüklüğünde deprem meydana geldi.Afet ve Acil Durum Yönetimi Başkanlığının internet sitesinde yer alan bilgiye göre, saat 01.31'de, Ege Denizi'nin Yunanistan açıklarında 4,2 büyüklüğünde deprem kaydedildi.Deniz yüzeyinin 12,50 kilometre derinliğindeki depremin merkez üssünün Yunanistan'a 13,80 kilometre, Çanakkale'nin Gökçeada ilçesine ise 114,11 kilometre mesafede olduğu belirlendi.",
                        Category = "Güncel",
                        Ozet = "Ege Denizi'nde 4,2 büyüklüğünde deprem meydana geldi.",
                        ResimYol = "/img/deprem.jpg"
                    },
                    new Product {
                        İcerik = "Ege Denizi'nde 4,2 büyüklüğünde deprem meydana geldi.Afet ve Acil Durum Yönetimi Başkanlığının internet sitesinde yer alan bilgiye göre, saat 01.31'de, Ege Denizi'nin Yunanistan açıklarında 4,2 büyüklüğünde deprem kaydedildi.Deniz yüzeyinin 12,50 kilometre derinliğindeki depremin merkez üssünün Yunanistan'a 13,80 kilometre, Çanakkale'nin Gökçeada ilçesine ise 114,11 kilometre mesafede olduğu belirlendi.",
                        Category = "Güncel",
                        Ozet = "Ege Denizi'nde 4,2 büyüklüğünde deprem meydana geldi.",
                        ResimYol = "/img/deprem.jpg"
                    },
                    new Product {
                        İcerik = "Ege Denizi'nde 4,2 büyüklüğünde deprem meydana geldi.Afet ve Acil Durum Yönetimi Başkanlığının internet sitesinde yer alan bilgiye göre, saat 01.31'de, Ege Denizi'nin Yunanistan açıklarında 4,2 büyüklüğünde deprem kaydedildi.Deniz yüzeyinin 12,50 kilometre derinliğindeki depremin merkez üssünün Yunanistan'a 13,80 kilometre, Çanakkale'nin Gökçeada ilçesine ise 114,11 kilometre mesafede olduğu belirlendi.",
                        Category = "Güncel",
                        Ozet = "Ege Denizi'nde 4,2 büyüklüğünde deprem meydana geldi.",
                        ResimYol = "/img/deprem.jpg"
                    },
                    new Product {
                        İcerik = "Ege Denizi'nde 4,2 büyüklüğünde deprem meydana geldi.Afet ve Acil Durum Yönetimi Başkanlığının internet sitesinde yer alan bilgiye göre, saat 01.31'de, Ege Denizi'nin Yunanistan açıklarında 4,2 büyüklüğünde deprem kaydedildi.Deniz yüzeyinin 12,50 kilometre derinliğindeki depremin merkez üssünün Yunanistan'a 13,80 kilometre, Çanakkale'nin Gökçeada ilçesine ise 114,11 kilometre mesafede olduğu belirlendi.",
                        Category = "Güncel",
                        Ozet = "Ege Denizi'nde 4,2 büyüklüğünde deprem meydana geldi.",
                        ResimYol = "/img/deprem.jpg"
                    },
                    new Product {
                        İcerik = "Ege Denizi'nde 4,2 büyüklüğünde deprem meydana geldi.Afet ve Acil Durum Yönetimi Başkanlığının internet sitesinde yer alan bilgiye göre, saat 01.31'de, Ege Denizi'nin Yunanistan açıklarında 4,2 büyüklüğünde deprem kaydedildi.Deniz yüzeyinin 12,50 kilometre derinliğindeki depremin merkez üssünün Yunanistan'a 13,80 kilometre, Çanakkale'nin Gökçeada ilçesine ise 114,11 kilometre mesafede olduğu belirlendi.",
                        Category = "Güncel",
                        Ozet = "Ege Denizi'nde 4,2 büyüklüğünde deprem meydana geldi.",
                        ResimYol = "/img/deprem.jpg"
                    },
                    new Product {
                        İcerik = "Ege Denizi'nde 4,2 büyüklüğünde deprem meydana geldi.Afet ve Acil Durum Yönetimi Başkanlığının internet sitesinde yer alan bilgiye göre, saat 01.31'de, Ege Denizi'nin Yunanistan açıklarında 4,2 büyüklüğünde deprem kaydedildi.Deniz yüzeyinin 12,50 kilometre derinliğindeki depremin merkez üssünün Yunanistan'a 13,80 kilometre, Çanakkale'nin Gökçeada ilçesine ise 114,11 kilometre mesafede olduğu belirlendi.",
                        Category = "Güncel",
                        Ozet = "Ege Denizi'nde 4,2 büyüklüğünde deprem meydana geldi.",
                        ResimYol = "/img/deprem.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
