using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Know_Your_Nation_Speedy.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnimationEntries",
                columns: table => new
                {
                    AnimationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    FileLocation = table.Column<string>(nullable: true),
                    CoverImageLocation = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimationEntries", x => x.AnimationId);
                });

            migrationBuilder.CreateTable(
                name: "ArticlesEntries",
                columns: table => new
                {
                    ArticleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    FileLocation = table.Column<string>(nullable: true),
                    CoverImageLocation = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    InRotation = table.Column<bool>(nullable: false),
                    Nation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticlesEntries", x => x.ArticleId);
                });

            migrationBuilder.CreateTable(
                name: "BookEntries",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    FileLocation = table.Column<string>(nullable: true),
                    CoverImageLocation = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookEntries", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "ComicEntries",
                columns: table => new
                {
                    ComicId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    FileLocation = table.Column<string>(nullable: true),
                    CoverImageLocation = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComicEntries", x => x.ComicId);
                });

            migrationBuilder.CreateTable(
                name: "ProductEntries",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CoverImageLocation = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    QuantityOnHand = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductEntries", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "UserEntries",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    MembershipType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEntries", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "VolunteerEventEntries",
                columns: table => new
                {
                    EventsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProjectName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolunteerEventEntries", x => x.EventsId);
                });

            migrationBuilder.CreateTable(
                name: "AnimationsWatchedEntries",
                columns: table => new
                {
                    AnimationId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    WatchedStatus = table.Column<bool>(nullable: false),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimationsWatchedEntries", x => new { x.UserId, x.AnimationId });
                    table.ForeignKey(
                        name: "FK_AnimationsWatchedEntries_AnimationEntries_AnimationId",
                        column: x => x.AnimationId,
                        principalTable: "AnimationEntries",
                        principalColumn: "AnimationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimationsWatchedEntries_UserEntries_UserId",
                        column: x => x.UserId,
                        principalTable: "UserEntries",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticlesReadEntries",
                columns: table => new
                {
                    ArticleId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    ReadStatus = table.Column<bool>(nullable: false),
                    GivenStatus = table.Column<bool>(nullable: false),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticlesReadEntries", x => new { x.UserId, x.ArticleId });
                    table.ForeignKey(
                        name: "FK_ArticlesReadEntries_ArticlesEntries_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "ArticlesEntries",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticlesReadEntries_UserEntries_UserId",
                        column: x => x.UserId,
                        principalTable: "UserEntries",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BooksReadEntries",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    ReadStatus = table.Column<bool>(nullable: false),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksReadEntries", x => new { x.UserId, x.BookId });
                    table.ForeignKey(
                        name: "FK_BooksReadEntries_BookEntries_BookId",
                        column: x => x.BookId,
                        principalTable: "BookEntries",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BooksReadEntries_UserEntries_UserId",
                        column: x => x.UserId,
                        principalTable: "UserEntries",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComicsReadEntries",
                columns: table => new
                {
                    ComicId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    ReadStatus = table.Column<bool>(nullable: false),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComicsReadEntries", x => new { x.UserId, x.ComicId });
                    table.ForeignKey(
                        name: "FK_ComicsReadEntries_ComicEntries_ComicId",
                        column: x => x.ComicId,
                        principalTable: "ComicEntries",
                        principalColumn: "ComicId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComicsReadEntries_UserEntries_UserId",
                        column: x => x.UserId,
                        principalTable: "UserEntries",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonationEntries",
                columns: table => new
                {
                    DonationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Organization = table.Column<string>(nullable: true),
                    AmountDonated = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationEntries", x => x.DonationId);
                    table.ForeignKey(
                        name: "FK_DonationEntries_UserEntries_UserId",
                        column: x => x.UserId,
                        principalTable: "UserEntries",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdersEntries",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateOrdered = table.Column<DateTime>(nullable: false),
                    TrackingNumber = table.Column<string>(nullable: true),
                    AddressToDeliever = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersEntries", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_OrdersEntries_UserEntries_UserId",
                        column: x => x.UserId,
                        principalTable: "UserEntries",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VolunteerEntries",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolunteerEntries", x => new { x.UserId, x.EventId });
                    table.ForeignKey(
                        name: "FK_VolunteerEntries_VolunteerEventEntries_EventId",
                        column: x => x.EventId,
                        principalTable: "VolunteerEventEntries",
                        principalColumn: "EventsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VolunteerEntries_UserEntries_UserId",
                        column: x => x.UserId,
                        principalTable: "UserEntries",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductOrdersEntries",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOrdersEntries", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductOrdersEntries_OrdersEntries_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrdersEntries",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductOrdersEntries_ProductEntries_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductEntries",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimationsWatchedEntries_AnimationId",
                table: "AnimationsWatchedEntries",
                column: "AnimationId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticlesReadEntries_ArticleId",
                table: "ArticlesReadEntries",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_BooksReadEntries_BookId",
                table: "BooksReadEntries",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_ComicsReadEntries_ComicId",
                table: "ComicsReadEntries",
                column: "ComicId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationEntries_UserId",
                table: "DonationEntries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersEntries_UserId",
                table: "OrdersEntries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrdersEntries_ProductId",
                table: "ProductOrdersEntries",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerEntries_EventId",
                table: "VolunteerEntries",
                column: "EventId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimationsWatchedEntries");

            migrationBuilder.DropTable(
                name: "ArticlesReadEntries");

            migrationBuilder.DropTable(
                name: "BooksReadEntries");

            migrationBuilder.DropTable(
                name: "ComicsReadEntries");

            migrationBuilder.DropTable(
                name: "DonationEntries");

            migrationBuilder.DropTable(
                name: "ProductOrdersEntries");

            migrationBuilder.DropTable(
                name: "VolunteerEntries");

            migrationBuilder.DropTable(
                name: "AnimationEntries");

            migrationBuilder.DropTable(
                name: "ArticlesEntries");

            migrationBuilder.DropTable(
                name: "BookEntries");

            migrationBuilder.DropTable(
                name: "ComicEntries");

            migrationBuilder.DropTable(
                name: "OrdersEntries");

            migrationBuilder.DropTable(
                name: "ProductEntries");

            migrationBuilder.DropTable(
                name: "VolunteerEventEntries");

            migrationBuilder.DropTable(
                name: "UserEntries");
        }
    }
}
