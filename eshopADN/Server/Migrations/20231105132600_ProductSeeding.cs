﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eshopADN.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Descrizione", "ImagePath", "Prezzo", "Titolo" },
                values: new object[,]
                {
                    { 1, "La torre sull'oceano: Una strana, assurda magia lega le anime di Isaac e di Viola. Lui è un solitario, malinconico artista che riesce ad incantare chiunque ascolti le note della sua armonica. Lei è bellissima, fragile e porta sulle spalle una vita difficile. Nessuno dei due riesce a capire cosa sia quella strana sensazione che li pervade quando, casualmente, incrociano gli sguardi. Eppure la loro storia non si intreccia con la soave delicatezza che ci si aspetterebbe da una storia d'amore. Per loro, le cose sono complesse ed oscure. Presto si incontreranno, in una situazione agli antipodi del romanticismo. E le cose, come sempre, non andranno come ci aspettiamo.", "https://www.unilibro.it/cover/libro/9788868543259B.jpg", 13.90m, "La torre sull'oceano" },
                    { 2, "Nicole ha trent'anni. Il mondo da tempo non è più quel luogo magico in cui credeva durante l'infanzia, tuttavia alla sua piccola Desirée, cinque anni, sua unica ragione di vita, vorrebbe mostrarlo così come lo ricorda. Ma il destino è beffardo e si prende gioco di lei, mandando all'aria ogni suo progetto, portandola a mettere in discussione ogni sua fede e costringendola ad affrontare quel segreto che si porta dentro e che, lentamente, la sta portando via.", "https://www.mondadoristore.it/img/Le-bastava-profumo-dell-erba-Nadia-Cristoni/ea978886628471/BL/BL/01/NZO/?tit=Le+bastava+il+profumo+dell%27erba&aut=Nadia+Cristoni", 17.00m, "Le bastava il profumo dell'erba" },
                    { 3, "Si intravede Bologna in filigrana, e la sua armoniosa, serena provincia, attraverso la storia di Penelope, una donna che non vuole crescere. Aiutata dal suo aspetto fisico, che nasconde la sua vera età, dall'entusiasmo per la vita, e da un bisogno quasi selvaggio di libertà, può forse permettersi di essere un'eterna bambina, anche se traumi, sensi di inadeguatezza e continui conflitti emergono prepotenti dal suo passato. Per sopravvivere a questi, e sperare di trasformarsi da crisalide in farfalla, dovrà superare le prove che rendono emotivamente adulti: la sconfitta, l'abbandono, la solitudine, l'amore. Affronterà ciascuna sfida con il suo proprio stile, a dispetto dell'età, delle convenienze e dei giudizi della società, e forse alla fine troverà il suo modo di stare al mondo. Forse.", "https://www.artedinadia.it/wp-content/uploads/2023/05/64-copertina.jpg", 17.00m, "Forse" },
                    { 4, "Una storia che si divide in due parti, dall’immediato dopoguerra agli inizi del 1970. La protagonista è Estelle, una diciannovenne in grado di comunicare con i morti e di farsi obbedire dal vento, elemento capace di purificare il peccato e trasformare la vita e la tristezza. Allevata in una una comunità gitana, inizierà un viaggio alla ricerca delle proprie origini. Creatura selvaggia e indomita, risorgerà sempre dalle sue ceneri grazie alla fede e alla forza che la contraddistinguono.\n\nUna vita fatta di conflitti, sofferenze e persecuzioni, quella di Estelle, personaggio emblematico e fuori dal tempo ma che, nel momento più difficile, saprà regalare forza e intuizione sufficienti per accettarsi e ritrovare la voglia di vivere.", "https://www.artedinadia.it/wp-content/uploads/2023/05/CopertinaLaReginadelVento-726x1024.jpg", 17.00m, "La regina del vento" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
