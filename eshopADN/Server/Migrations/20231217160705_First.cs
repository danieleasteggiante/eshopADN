using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eshopADN.Server.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Titolo = table.Column<string>(type: "text", nullable: false),
                    Descrizione = table.Column<string>(type: "text", nullable: false),
                    ImagePath = table.Column<string>(type: "text", nullable: false),
                    IsAvailable = table.Column<bool>(type: "boolean", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    ProductTypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => new { x.ProductId, x.ProductTypeId });
                    table.ForeignKey(
                        name: "FK_ProductVariants_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Nome", "Url" },
                values: new object[,]
                {
                    { 1, "Libri", "libri" },
                    { 2, "Quadri, ritratti e stampe", "quadri" },
                    { 3, "Decorazioni", "decorazioni" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Libro Cartaceo" },
                    { 2, "Ebook" },
                    { 3, "Ritratto su commissione sm(30x40)" },
                    { 4, "Ritratto su commissione md(50x70)" },
                    { 5, "Ritratto su commissione lg(70x100)" },
                    { 6, "Dipinto su commissione sm(30x40)" },
                    { 7, "Dipinto su commissione md(50x70)" },
                    { 8, "Dipinto su commissione lg(70x100)" },
                    { 9, "Come da immagine" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Descrizione", "ImagePath", "IsAvailable", "Titolo" },
                values: new object[,]
                {
                    { 1, 1, "La torre sull'oceano: Una strana, assurda magia lega le anime di Isaac e di Viola. Lui è un solitario, malinconico artista che riesce ad incantare chiunque ascolti le note della sua armonica. Lei è bellissima, fragile e porta sulle spalle una vita difficile. Nessuno dei due riesce a capire cosa sia quella strana sensazione che li pervade quando, casualmente, incrociano gli sguardi. Eppure la loro storia non si intreccia con la soave delicatezza che ci si aspetterebbe da una storia d'amore. Per loro, le cose sono complesse ed oscure. Presto si incontreranno, in una situazione agli antipodi del romanticismo. E le cose, come sempre, non andranno come ci aspettiamo.", "https://www.unilibro.it/cover/libro/9788868543259B.jpg", false, "La torre sull'oceano" },
                    { 2, 1, "Nicole ha trent'anni. Il mondo da tempo non è più quel luogo magico in cui credeva durante l'infanzia, tuttavia alla sua piccola Desirée, cinque anni, sua unica ragione di vita, vorrebbe mostrarlo così come lo ricorda. Ma il destino è beffardo e si prende gioco di lei, mandando all'aria ogni suo progetto, portandola a mettere in discussione ogni sua fede e costringendola ad affrontare quel segreto che si porta dentro e che, lentamente, la sta portando via.", "https://www.mondadoristore.it/img/Le-bastava-profumo-dell-erba-Nadia-Cristoni/ea978886628471/BL/BL/01/NZO/?tit=Le+bastava+il+profumo+dell%27erba&aut=Nadia+Cristoni", false, "Le bastava il profumo dell'erba" },
                    { 3, 1, "Si intravede Bologna in filigrana, e la sua armoniosa, serena provincia, attraverso la storia di Penelope, una donna che non vuole crescere. Aiutata dal suo aspetto fisico, che nasconde la sua vera età, dall'entusiasmo per la vita, e da un bisogno quasi selvaggio di libertà, può forse permettersi di essere un'eterna bambina, anche se traumi, sensi di inadeguatezza e continui conflitti emergono prepotenti dal suo passato. Per sopravvivere a questi, e sperare di trasformarsi da crisalide in farfalla, dovrà superare le prove che rendono emotivamente adulti: la sconfitta, l'abbandono, la solitudine, l'amore. Affronterà ciascuna sfida con il suo proprio stile, a dispetto dell'età, delle convenienze e dei giudizi della società, e forse alla fine troverà il suo modo di stare al mondo. Forse.", "https://www.artedinadia.it/wp-content/uploads/2023/05/64-copertina.jpg", false, "Forse" },
                    { 4, 1, "Una storia che si divide in due parti, dall’immediato dopoguerra agli inizi del 1970. La protagonista è Estelle, una diciannovenne in grado di comunicare con i morti e di farsi obbedire dal vento, elemento capace di purificare il peccato e trasformare la vita e la tristezza. Allevata in una una comunità gitana, inizierà un viaggio alla ricerca delle proprie origini. Creatura selvaggia e indomita, risorgerà sempre dalle sue ceneri grazie alla fede e alla forza che la contraddistinguono.\n\nUna vita fatta di conflitti, sofferenze e persecuzioni, quella di Estelle, personaggio emblematico e fuori dal tempo ma che, nel momento più difficile, saprà regalare forza e intuizione sufficienti per accettarsi e ritrovare la voglia di vivere.", "https://www.artedinadia.it/wp-content/uploads/2023/05/CopertinaLaReginadelVento-726x1024.jpg", false, "La regina del vento" },
                    { 5, 2, "Progettazione di ritratti su misure standard o personalizzate. Il ritratto è un'opera d'arte che rappresenta una persona o un gruppo di persone. Il ritratto può essere realizzato in diversi modi: pittura, disegno, fotografia, scultura, ecc. Il ritratto è un'opera d'arte che rappresenta una persona o un gruppo di persone. Il ritratto può essere realizzato in diversi modi: pittura, disegno, fotografia, scultura, ecc.", "https://www.artedinadia.it/wp-content/gallery/quadri/esercitazione-a-spatola.jpg", false, "Ritratto su commissione" },
                    { 6, 3, "Decorazioni su pareti, tessuti, mobili e oggetti. Soggetti e colori personalizzabili. Il ritratto è un'opera d'arte che rappresenta una persona o un gruppo di persone. Il ritratto può essere realizzato in diversi modi: pittura, disegno, fotografia, scultura, ecc. Il ritratto è un'opera d'arte che rappresenta una persona o un gruppo di persone. Il ritratto può essere realizzato in diversi modi: pittura, disegno, fotografia, scultura, ecc.", "https://www.artedinadia.it/wp-content/gallery/quadri/esercitazione-a-spatola.jpg", false, "Decorazione su commissione" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductTypeId",
                table: "ProductVariants",
                column: "ProductTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
