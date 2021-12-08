using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Aliens.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aliens",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(nullable: true),
                    planet = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aliens", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "groups_aliens",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groups_aliens", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "groups_people",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groups_people", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "people",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(nullable: true),
                    age = table.Column<int>(nullable: false),
                    country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_people", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "spaceships",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(nullable: true),
                    model = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spaceships", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "group_alien",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_groupid = table.Column<int>(nullable: true),
                    id_alienid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_group_alien", x => x.id);
                    table.ForeignKey(
                        name: "FK_group_alien_aliens_id_alienid",
                        column: x => x.id_alienid,
                        principalTable: "aliens",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_group_alien_groups_aliens_id_groupid",
                        column: x => x.id_groupid,
                        principalTable: "groups_aliens",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "group_person",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_groupid = table.Column<int>(nullable: true),
                    id_personid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_group_person", x => x.id);
                    table.ForeignKey(
                        name: "FK_group_person_groups_people_id_groupid",
                        column: x => x.id_groupid,
                        principalTable: "groups_people",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_group_person_people_id_personid",
                        column: x => x.id_personid,
                        principalTable: "people",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "murders",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date = table.Column<DateTime>(nullable: false),
                    id_personid = table.Column<int>(nullable: true),
                    id_alienid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_murders", x => x.id);
                    table.ForeignKey(
                        name: "FK_murders_aliens_id_alienid",
                        column: x => x.id_alienid,
                        principalTable: "aliens",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_murders_people_id_personid",
                        column: x => x.id_personid,
                        principalTable: "people",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "abductions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date = table.Column<DateTime>(nullable: false),
                    id_personid = table.Column<int>(nullable: true),
                    id_alienid = table.Column<int>(nullable: true),
                    id_spaceshipid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abductions", x => x.id);
                    table.ForeignKey(
                        name: "FK_abductions_aliens_id_alienid",
                        column: x => x.id_alienid,
                        principalTable: "aliens",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_abductions_people_id_personid",
                        column: x => x.id_personid,
                        principalTable: "people",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_abductions_spaceships_id_spaceshipid",
                        column: x => x.id_spaceshipid,
                        principalTable: "spaceships",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "escapes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date = table.Column<DateTime>(nullable: false),
                    id_personid = table.Column<int>(nullable: true),
                    id_spaceshipid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_escapes", x => x.id);
                    table.ForeignKey(
                        name: "FK_escapes_people_id_personid",
                        column: x => x.id_personid,
                        principalTable: "people",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_escapes_spaceships_id_spaceshipid",
                        column: x => x.id_spaceshipid,
                        principalTable: "spaceships",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "excursions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date = table.Column<DateTime>(nullable: false),
                    id_alienid = table.Column<int>(nullable: true),
                    id_group_peopleid = table.Column<int>(nullable: true),
                    id_spaceshipid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_excursions", x => x.id);
                    table.ForeignKey(
                        name: "FK_excursions_aliens_id_alienid",
                        column: x => x.id_alienid,
                        principalTable: "aliens",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_excursions_groups_people_id_group_peopleid",
                        column: x => x.id_group_peopleid,
                        principalTable: "groups_people",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_excursions_spaceships_id_spaceshipid",
                        column: x => x.id_spaceshipid,
                        principalTable: "spaceships",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "experiments",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date = table.Column<DateTime>(nullable: false),
                    id_personid = table.Column<int>(nullable: true),
                    id_group_aliensid = table.Column<int>(nullable: true),
                    id_spaceshipid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_experiments", x => x.id);
                    table.ForeignKey(
                        name: "FK_experiments_groups_aliens_id_group_aliensid",
                        column: x => x.id_group_aliensid,
                        principalTable: "groups_aliens",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_experiments_people_id_personid",
                        column: x => x.id_personid,
                        principalTable: "people",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_experiments_spaceships_id_spaceshipid",
                        column: x => x.id_spaceshipid,
                        principalTable: "spaceships",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "transportations",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date = table.Column<DateTime>(nullable: false),
                    id_personid = table.Column<int>(nullable: true),
                    id_spaceship_fromid = table.Column<int>(nullable: true),
                    id_spaceship_toid = table.Column<int>(nullable: true),
                    id_alienid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transportations", x => x.id);
                    table.ForeignKey(
                        name: "FK_transportations_aliens_id_alienid",
                        column: x => x.id_alienid,
                        principalTable: "aliens",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_transportations_people_id_personid",
                        column: x => x.id_personid,
                        principalTable: "people",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_transportations_spaceships_id_spaceship_fromid",
                        column: x => x.id_spaceship_fromid,
                        principalTable: "spaceships",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_transportations_spaceships_id_spaceship_toid",
                        column: x => x.id_spaceship_toid,
                        principalTable: "spaceships",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_abductions_id_alienid",
                table: "abductions",
                column: "id_alienid");

            migrationBuilder.CreateIndex(
                name: "IX_abductions_id_personid",
                table: "abductions",
                column: "id_personid");

            migrationBuilder.CreateIndex(
                name: "IX_abductions_id_spaceshipid",
                table: "abductions",
                column: "id_spaceshipid");

            migrationBuilder.CreateIndex(
                name: "IX_escapes_id_personid",
                table: "escapes",
                column: "id_personid");

            migrationBuilder.CreateIndex(
                name: "IX_escapes_id_spaceshipid",
                table: "escapes",
                column: "id_spaceshipid");

            migrationBuilder.CreateIndex(
                name: "IX_excursions_id_alienid",
                table: "excursions",
                column: "id_alienid");

            migrationBuilder.CreateIndex(
                name: "IX_excursions_id_group_peopleid",
                table: "excursions",
                column: "id_group_peopleid");

            migrationBuilder.CreateIndex(
                name: "IX_excursions_id_spaceshipid",
                table: "excursions",
                column: "id_spaceshipid");

            migrationBuilder.CreateIndex(
                name: "IX_experiments_id_group_aliensid",
                table: "experiments",
                column: "id_group_aliensid");

            migrationBuilder.CreateIndex(
                name: "IX_experiments_id_personid",
                table: "experiments",
                column: "id_personid");

            migrationBuilder.CreateIndex(
                name: "IX_experiments_id_spaceshipid",
                table: "experiments",
                column: "id_spaceshipid");

            migrationBuilder.CreateIndex(
                name: "IX_group_alien_id_alienid",
                table: "group_alien",
                column: "id_alienid");

            migrationBuilder.CreateIndex(
                name: "IX_group_alien_id_groupid",
                table: "group_alien",
                column: "id_groupid");

            migrationBuilder.CreateIndex(
                name: "IX_group_person_id_groupid",
                table: "group_person",
                column: "id_groupid");

            migrationBuilder.CreateIndex(
                name: "IX_group_person_id_personid",
                table: "group_person",
                column: "id_personid");

            migrationBuilder.CreateIndex(
                name: "IX_murders_id_alienid",
                table: "murders",
                column: "id_alienid");

            migrationBuilder.CreateIndex(
                name: "IX_murders_id_personid",
                table: "murders",
                column: "id_personid");

            migrationBuilder.CreateIndex(
                name: "IX_transportations_id_alienid",
                table: "transportations",
                column: "id_alienid");

            migrationBuilder.CreateIndex(
                name: "IX_transportations_id_personid",
                table: "transportations",
                column: "id_personid");

            migrationBuilder.CreateIndex(
                name: "IX_transportations_id_spaceship_fromid",
                table: "transportations",
                column: "id_spaceship_fromid");

            migrationBuilder.CreateIndex(
                name: "IX_transportations_id_spaceship_toid",
                table: "transportations",
                column: "id_spaceship_toid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "abductions");

            migrationBuilder.DropTable(
                name: "escapes");

            migrationBuilder.DropTable(
                name: "excursions");

            migrationBuilder.DropTable(
                name: "experiments");

            migrationBuilder.DropTable(
                name: "group_alien");

            migrationBuilder.DropTable(
                name: "group_person");

            migrationBuilder.DropTable(
                name: "murders");

            migrationBuilder.DropTable(
                name: "transportations");

            migrationBuilder.DropTable(
                name: "groups_aliens");

            migrationBuilder.DropTable(
                name: "groups_people");

            migrationBuilder.DropTable(
                name: "aliens");

            migrationBuilder.DropTable(
                name: "people");

            migrationBuilder.DropTable(
                name: "spaceships");
        }
    }
}
