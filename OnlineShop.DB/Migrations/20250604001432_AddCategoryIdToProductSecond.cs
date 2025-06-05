using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineShop.DB.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryIdToProductSecond : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2842320a-f42d-4f81-880f-488778526f5d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f74b568-cf38-4caa-92c3-dbc45437a2aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f15a38b-fcb6-4241-87e8-8148e148e5b4"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06fe75f0-09f2-4489-8d11-42f6c816baef"),
                columns: new[] { "CategoryId", "Cost", "Description", "Name" },
                values: new object[] { 1, 1680m, "Сухий раціон містить м’ясні інгредієнти на першому місці у Складі, збалансоване поєднання білків та жирів 24/13 та чудово смакує собакам середніх порід вагою від 11 до 25 кг і віком від 1 року.", "Сухий корм для дорослих собак Club 4 Paws (Клуб 4 Лапи) Преміум для середніх порід 14 кг" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("168defec-16fe-4dec-8db1-8d968036bd89"),
                columns: new[] { "CategoryId", "Cost", "Description", "Name" },
                values: new object[] { 4, 550m, "Лінійка New Classic — перевірена часом серія повідців-рулеток для приємних прогулянок із вихованцем. Рулетки Flexi New Classic S характеризуються надійністю та зручністю.", "Рулетка Flexi New Classic S 5м Синяя" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f06e50b-989b-4827-89db-4859d1d49998"),
                columns: new[] { "CategoryId", "Cost", "Description", "Name" },
                values: new object[] { 3, 1235m, "Не завжди встигаєте чи забуваєте нагодувати та напоїти свого домашнього улюбленця? Тоді цей комплект поїлки та годівниці саме те, що вам потрібно. Він подбає про те, щоб ваш вихованець завжди отримав свіжу порцію корму та питної води.", "Годівниця та поїлка для котів та собак Hoopet 2 x 3.5L, комплект Сірий" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c9d0079-8bdd-43bb-beba-bcde5a43d6c7"),
                columns: new[] { "CategoryId", "Cost", "Description", "Name" },
                values: new object[] { 5, 368m, "Шампунь Trixie з оліями макадамії й обліпихи для собак — прекрасний варіант для купання тварин, чия шерсть потребує додаткового підживлення корисними речовинами.", "Шампунь Trixie 2910 з маслами макадамії і обліпихи 1л" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3765151-d68f-41ea-a8b9-27bae6f2b8a0"),
                columns: new[] { "CategoryId", "Cost", "Description", "Name" },
                values: new object[] { 2, 178m, "Свійські тварини незмінно залишаються в центрі уваги компанії Trixie вже понад 40 років. Цікавість і любов до свійських тварин і їхніх власників допомагають компанії безперервно розвиватися. Широкий діапазон продуктів компанії експортується до понад 60 країн.", "М'яч бейсбольний Denta Fun Mintfresh Trixie 3289 7 см" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06fe75f0-09f2-4489-8d11-42f6c816baef"),
                columns: new[] { "CategoryId", "Cost", "Description", "Name" },
                values: new object[] { 0, 69999m, "Телевизор Samsung QE43QBAU — модель, которая произведена по технологии QLED, что гарантирует вывод насыщенной и яркой картинки. ", "Телевизор Samsung QE43QBAU1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("168defec-16fe-4dec-8db1-8d968036bd89"),
                columns: new[] { "CategoryId", "Cost", "Description", "Name" },
                values: new object[] { 0, 99999m, "Игровой ноутбук MSI Katana 17 B12VEK-482XRU выполнен в пластиковом корпусе размерами 25,2х398х273 мм и весом 2,6 кг.", "Ноутбук игровой MSI Katana 17 B12VEK-482XRU" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f06e50b-989b-4827-89db-4859d1d49998"),
                columns: new[] { "CategoryId", "Cost", "Description", "Name" },
                values: new object[] { 0, 18999m, "Робот-пылесос Dreame Bot Robot Vacuum and Mop D9 Pro White выполняет сухую и влажную уборку и способен обработать до 1 м² площади без подзарядки", "Робот-пылесос Dreame Bot Robot Vacuum and Mop F9 Pro White" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c9d0079-8bdd-43bb-beba-bcde5a43d6c7"),
                columns: new[] { "CategoryId", "Cost", "Description", "Name" },
                values: new object[] { 0, 29999m, "Gorenje BO67372X – электрический духовой шкаф с 77-литровой камерой BigSpace. За счёт внушительного объёма внутреннего пространства и его особой форме HomeMade вам будут по плечу самые смелые кулинарные эксперименты.", "Электрический духовой шкаф Gorenje BO67372X" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3765151-d68f-41ea-a8b9-27bae6f2b8a0"),
                columns: new[] { "CategoryId", "Cost", "Description", "Name" },
                values: new object[] { 0, 79999m, "Холодильник Midea MDRB499FG1IM, белый оснащен холодильной камерой объемом 2 л и нижней морозильной камерой объемом 76 л.", "Холодильник Midea MDRB499FG1IM" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CompareId", "Cost", "Description", "FavouriteId", "Name" },
                values: new object[,]
                {
                    { new Guid("2842320a-f42d-4f81-880f-488778526f5d"), 0, null, 19999m, "Компактная морозильная камера Haier HF-82WAA – хороший выбор для тех, кто хочет хранить дома или на даче запас замороженных продуктов и полуфабрикатов, а также делать домашние заготовки.", null, "Морозильная камера Haier HF-82WAA" },
                    { new Guid("6f74b568-cf38-4caa-92c3-dbc45437a2aa"), 0, null, 25999m, "Сплит-система Haier HSU7HRM3/R3 в корпусе белого цвета заправлена хладагентом R 32. Устройство работает на охлаждение и обогрев. Модель рекомендована для установки в помещениях площадью до  м². В комплект входит пульт дистанционного управления с дисплеем.", null, "Сплит-система Haier HSU7HRM3/R3" },
                    { new Guid("7f15a38b-fcb6-4241-87e8-8148e148e5b4"), 0, null, 9999m, "Встраиваемая электрическая панель Gorenje ECT641BX снабжена четырьмя конфорками, установленными под стеклокерамической поверхностью.", null, "Встраиваемая электрическая панель Gorenje ECT641BX" }
                });
        }
    }
}
