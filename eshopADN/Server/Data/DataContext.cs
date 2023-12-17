using Microsoft.EntityFrameworkCore;

namespace eshopADN.Server.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductVariant>().HasKey(
            variant => new { variant.ProductId, variant.ProductTypeId });

        modelBuilder.Entity<ProductType>().HasData(
            new ProductType()
            {
                Id = 1,
                Nome = "Libro Cartaceo"
            },
            new ProductType()
            {
                Id = 2,
                Nome = "Ebook"
            },
            new ProductType()
            {
                Id = 3,
                Nome = "Ritratto su commissione sm(30x40)"
            },
            new ProductType()
            {
                Id = 4,
                Nome = "Ritratto su commissione md(50x70)"
            },
            new ProductType()
            {
                Id = 5,
                Nome = "Ritratto su commissione lg(70x100)"
            },
            new ProductType()
            {
                Id = 6,
                Nome = "Dipinto su commissione sm(30x40)"
            },
            new ProductType()
            {
                Id = 7,
                Nome = "Dipinto su commissione md(50x70)"
            },
            new ProductType()
            {
                Id = 8,
                Nome = "Dipinto su commissione lg(70x100)"
            },
            new ProductType()
            {
                Id = 9,
                Nome = "Come da immagine"
            }
        );
        modelBuilder.Entity<Category>().HasData(
            new Category()
            {
                Id = 1,
                Nome = "Libri",
                Url = "libri"
            },
            new Category()
            {
                Id = 2,
                Nome = "Quadri, ritratti e stampe",
                Url = "quadri"
            },
            new Category()
            {
                Id = 3,
                Nome = "Decorazioni",
                Url = "decorazioni"
            }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Titolo = "La torre sull'oceano",
                Descrizione =
                    "La torre sull'oceano: Una strana, assurda magia lega le anime di Isaac e di Viola. Lui è un solitario, malinconico artista che riesce ad incantare chiunque ascolti le note della sua armonica. Lei è bellissima, fragile e porta sulle spalle una vita difficile. Nessuno dei due riesce a capire cosa sia quella strana sensazione che li pervade quando, casualmente, incrociano gli sguardi. Eppure la loro storia non si intreccia con la soave delicatezza che ci si aspetterebbe da una storia d'amore. Per loro, le cose sono complesse ed oscure. Presto si incontreranno, in una situazione agli antipodi del romanticismo. E le cose, come sempre, non andranno come ci aspettiamo.",
                ImagePath = "https://www.unilibro.it/cover/libro/9788868543259B.jpg",
                CategoryId = 1
            },
            new Product
            {
                Id = 2,
                Titolo = "Le bastava il profumo dell'erba",
                Descrizione =
                    "Nicole ha trent'anni. Il mondo da tempo non è più quel luogo magico in cui credeva durante l'infanzia, tuttavia alla sua piccola Desirée, cinque anni, sua unica ragione di vita, vorrebbe mostrarlo così come lo ricorda. Ma il destino è beffardo e si prende gioco di lei, mandando all'aria ogni suo progetto, portandola a mettere in discussione ogni sua fede e costringendola ad affrontare quel segreto che si porta dentro e che, lentamente, la sta portando via.",
                ImagePath =
                    "https://www.mondadoristore.it/img/Le-bastava-profumo-dell-erba-Nadia-Cristoni/ea978886628471/BL/BL/01/NZO/?tit=Le+bastava+il+profumo+dell%27erba&aut=Nadia+Cristoni",
                CategoryId = 1

            },
            new Product
            {
                Id = 3,
                Titolo = "Forse",
                Descrizione =
                    "Si intravede Bologna in filigrana, e la sua armoniosa, serena provincia, attraverso la storia di Penelope, una donna che non vuole crescere. Aiutata dal suo aspetto fisico, che nasconde la sua vera età, dall'entusiasmo per la vita, e da un bisogno quasi selvaggio di libertà, può forse permettersi di essere un'eterna bambina, anche se traumi, sensi di inadeguatezza e continui conflitti emergono prepotenti dal suo passato. Per sopravvivere a questi, e sperare di trasformarsi da crisalide in farfalla, dovrà superare le prove che rendono emotivamente adulti: la sconfitta, l'abbandono, la solitudine, l'amore. Affronterà ciascuna sfida con il suo proprio stile, a dispetto dell'età, delle convenienze e dei giudizi della società, e forse alla fine troverà il suo modo di stare al mondo. Forse.",
                ImagePath = "https://www.artedinadia.it/wp-content/uploads/2023/05/64-copertina.jpg",
                CategoryId = 1

            },
            new Product
            {
                Id = 4,
                Titolo = "La regina del vento",
                Descrizione =
                    "Una storia che si divide in due parti, dall’immediato dopoguerra agli inizi del 1970. La protagonista è Estelle, una diciannovenne in grado di comunicare con i morti e di farsi obbedire dal vento, elemento capace di purificare il peccato e trasformare la vita e la tristezza. Allevata in una una comunità gitana, inizierà un viaggio alla ricerca delle proprie origini. Creatura selvaggia e indomita, risorgerà sempre dalle sue ceneri grazie alla fede e alla forza che la contraddistinguono.\n\nUna vita fatta di conflitti, sofferenze e persecuzioni, quella di Estelle, personaggio emblematico e fuori dal tempo ma che, nel momento più difficile, saprà regalare forza e intuizione sufficienti per accettarsi e ritrovare la voglia di vivere.",
                ImagePath =
                    "https://www.artedinadia.it/wp-content/uploads/2023/05/CopertinaLaReginadelVento-726x1024.jpg",
                CategoryId = 1
            },
            new Product
            {
                Id = 5,
                Titolo = "Ritratto su commissione",
                Descrizione =
                    "Progettazione di ritratti su misure standard o personalizzate. Il ritratto è un'opera d'arte che rappresenta una persona o un gruppo di persone. Il ritratto può essere realizzato in diversi modi: pittura, disegno, fotografia, scultura, ecc. Il ritratto è un'opera d'arte che rappresenta una persona o un gruppo di persone. Il ritratto può essere realizzato in diversi modi: pittura, disegno, fotografia, scultura, ecc.",
                ImagePath =
                    "https://www.artedinadia.it/wp-content/gallery/quadri/esercitazione-a-spatola.jpg",
                CategoryId = 2
            },
            new Product
            {
                Id = 6,
                Titolo = "Decorazione su commissione",
                Descrizione =
                    "Decorazioni su pareti, tessuti, mobili e oggetti. Soggetti e colori personalizzabili. Il ritratto è un'opera d'arte che rappresenta una persona o un gruppo di persone. Il ritratto può essere realizzato in diversi modi: pittura, disegno, fotografia, scultura, ecc. Il ritratto è un'opera d'arte che rappresenta una persona o un gruppo di persone. Il ritratto può essere realizzato in diversi modi: pittura, disegno, fotografia, scultura, ecc.",
                ImagePath =
                    "https://www.artedinadia.it/wp-content/gallery/quadri/esercitazione-a-spatola.jpg",
                CategoryId = 3
            }
        );

        modelBuilder.Entity<ProductVariant>().HasData(
            new ProductVariant()
            {
                ProductId = 1,
                ProductTypeId = 1,
                Price = 15.99m,
                OriginalPrice = 19.99m
            },
            new ProductVariant()
            {
                ProductId = 1,
                ProductTypeId = 2,
                Price = 9.99m,
                OriginalPrice = 12.99m
            },
            new ProductVariant()
            {
                ProductId = 2,
                ProductTypeId = 1,
                Price = 15.99m,
                OriginalPrice = 19.99m
            },
            new ProductVariant()
            {
                ProductId = 2,
                ProductTypeId = 2,
                Price = 9.99m,
                OriginalPrice = 12.99m
            },
            new ProductVariant()
            {
                ProductId = 3,
                ProductTypeId = 1,
                Price = 15.99m,
                OriginalPrice = 19.99m
            },
            new ProductVariant()
            {
                ProductId = 3,
                ProductTypeId = 2,
                Price = 9.99m,
                OriginalPrice = 12.99m
            },
            new ProductVariant()
            {
                ProductId = 4,
                ProductTypeId = 1,
                Price = 15.99m,
                OriginalPrice = 19.99m
            },
            new ProductVariant()
            {
                ProductId = 4,
                ProductTypeId = 2,
                Price = 9.99m,
                OriginalPrice = 12.99m
            },
            new ProductVariant()
            {
                ProductId = 5,
                ProductTypeId = 3,
                Price = 49.99m,
                OriginalPrice = 59.99m
            },
            new ProductVariant()
            {
                ProductId = 5,
                ProductTypeId = 4,
                Price = 79.99m,
                OriginalPrice = 99.99m
            },
            new ProductVariant()
            {
                ProductId = 5,
                ProductTypeId = 5,
                Price = 99.99m,
                OriginalPrice = 129.99m
            },
            new ProductVariant()
            {
                ProductId = 6,
                ProductTypeId = 6,
                Price = 49.99m,
                OriginalPrice = 59.99m
            },
            new ProductVariant()
            {
                ProductId = 6,
                ProductTypeId = 7,
                Price = 79.99m,
                OriginalPrice = 99.99m
            },
            new ProductVariant()
            {
                ProductId = 6,
                ProductTypeId = 8,
                Price = 99.99m,
                OriginalPrice = 129.99m
            }
        );
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ProductType> ProductTypes { get; set; }
    public DbSet<ProductVariant> ProductVariants { get; set; }
    
}