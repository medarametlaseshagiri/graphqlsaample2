using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphQLSample.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("72714910-0381-4fd4-a76c-b107ac632867"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("b70f39c2-8277-4fe5-9f31-39e84ebd5f0b"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("b80667a3-06b0-4ba0-bd3f-0599e5fb378c"));

            migrationBuilder.CreateTable(
                name: "SHPViewDlogWithAudit",
                columns: table => new
                {
                    SBSB_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TRANSACTION_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BF_TRANS_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MEME_SFX = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MEME_LAST_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MEME_FIRST_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MEME_MID_INIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MEME_REL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MEME_CK = table.Column<int>(type: "int", nullable: false),
                    MEME_SSN = table.Column<int>(type: "int", nullable: false),
                    MEME_SEX = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MEME_BIRTH_DT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BF_FILE_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BF_COV_EFF_DT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BF_EXP_DT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MEPE_EFF_DT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MEPE_TERM_DT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MEPE_ELIG_IND = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CSPD_CAT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CSPI_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SGSG_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SGSG_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CSCS_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MEPR_EFF_DT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MEPR_TERM_DT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MEPR_PCP_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PRPR_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MEPR_MCTR_TRSN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MEPR_MCTR_ORSN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KEY_EFF_DT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KEY_TERM_DT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    XMS_FILE_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XMS_FAM_SEQ_NO = table.Column<int>(type: "int", nullable: false),
                    BF_PVSR_FNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BF_PVSR_CITY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BF_PVSR_LNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MCTR_TRSN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Provider_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AFFILIATION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAX_BATCH_ID = table.Column<int>(type: "int", nullable: false),
                    IMAX_TRANS_STATE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAX_ERROR_MSG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAX_GROUP_IDENTIFIER = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAX_SGSG_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAX_NEW_MEMBER_TRIGGER = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAX_SUBGRP_CHG_TRIGGER = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAX_PCP_TRIGGER = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAX_COB_TRIGGER = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAX_ATTACHMENT_TRIGGER = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MEMBER_ADDR_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SBAD_ADDR_1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SBAD_ADDR_2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SBAD_CITY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SBAD_COUNTY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SBAD_STATE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SBAD_ZIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SBAD_COUNTRY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAX_BENEFIT_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAX_TRANSACTION_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAX_COVERAGE_INDICATOR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAX_PRODUCT_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAX_PRPR_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAX_PCP_CODE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAX_PCP_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAX_PCP_EFF_DT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IMAX_PCP_GROUP_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAX_PCP_SERVICE_LOC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAX_HICN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAX_ELIGIBILITY_RSN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAX_MEDICARE_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAX_ELIG_DT = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SHPViewDlogWithAudit", x => x.SBSB_ID);
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("7d176e83-67de-4ff3-981d-f72fe107f1bc"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", "Batman" },
                    { new Guid("c87b8af0-f7b2-4427-b01f-db40ec22bc94"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", "Luke Skywalker" },
                    { new Guid("ecb30191-c049-4acc-b84f-0dc2b363d31c"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", "Black Widow" }
                });

            migrationBuilder.InsertData(
                table: "SHPViewDlogWithAudit",
                columns: new[] { "SBSB_ID", "AFFILIATION", "BF_COV_EFF_DT", "BF_EXP_DT", "BF_FILE_TYPE", "BF_PVSR_CITY", "BF_PVSR_FNAME", "BF_PVSR_LNAME", "BF_TRANS_TYPE", "CSCS_ID", "CSPD_CAT", "CSPI_ID", "Details", "IMAX_ATTACHMENT_TRIGGER", "IMAX_BATCH_ID", "IMAX_BENEFIT_TYPE", "IMAX_COB_TRIGGER", "IMAX_COVERAGE_INDICATOR", "IMAX_ELIGIBILITY_RSN", "IMAX_ELIG_DT", "IMAX_ERROR_MSG", "IMAX_GROUP_IDENTIFIER", "IMAX_HICN", "IMAX_MEDICARE_TYPE", "IMAX_NEW_MEMBER_TRIGGER", "IMAX_PCP_CODE", "IMAX_PCP_EFF_DT", "IMAX_PCP_GROUP_ID", "IMAX_PCP_NAME", "IMAX_PCP_SERVICE_LOC", "IMAX_PCP_TRIGGER", "IMAX_PRODUCT_ID", "IMAX_PRPR_ID", "IMAX_SGSG_NAME", "IMAX_SUBGRP_CHG_TRIGGER", "IMAX_TRANSACTION_TYPE", "IMAX_TRANS_STATE", "KEY_EFF_DT", "KEY_TERM_DT", "Location_Id", "MCTR_TRSN", "MEMBER_ADDR_ID", "MEME_BIRTH_DT", "MEME_CK", "MEME_FIRST_NAME", "MEME_LAST_NAME", "MEME_MID_INIT", "MEME_REL", "MEME_SEX", "MEME_SFX", "MEME_SSN", "MEPE_EFF_DT", "MEPE_ELIG_IND", "MEPE_TERM_DT", "MEPR_EFF_DT", "MEPR_MCTR_ORSN", "MEPR_MCTR_TRSN", "MEPR_PCP_TYPE", "MEPR_TERM_DT", "PRPR_ID", "Provider_Id", "SBAD_ADDR_1", "SBAD_ADDR_2", "SBAD_CITY", "SBAD_COUNTRY", "SBAD_COUNTY", "SBAD_STATE", "SBAD_ZIP", "SGSG_ID", "SGSG_NAME", "TRANSACTION_DATE", "XMS_FAM_SEQ_NO", "XMS_FILE_ID" },
                values: new object[,]
                {
                    { "651682e2-b373-4c4b-9ae0-34eb1183907f", "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "", "", "", "", "", "", "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", "", 1, "", "", "", "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "", "", "", "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "", "", "", "", "", "", "", "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Batman", "", "", "", "", "", 1, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "", "", "", "", "", "", "", "", "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "" },
                    { "a390f402-25a6-4a13-ba48-237771f66ce4", "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "", "", "", "", "", "", "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", "", 1, "", "", "", "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "", "", "", "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "", "", "", "", "", "", "", "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Black Widow", "", "", "", "", "", 1, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "", "", "", "", "", "", "", "", "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "" },
                    { "b52fdcfb-080d-4f3a-93b0-95939993b59c", "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "", "", "", "", "", "", "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", "", 1, "", "", "", "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "", "", "", "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "", "", "", "", "", "", "", "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Luke Skywalker", "", "", "", "", "", 1, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "", "", "", "", "", "", "", "", "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SHPViewDlogWithAudit");

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("7d176e83-67de-4ff3-981d-f72fe107f1bc"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("c87b8af0-f7b2-4427-b01f-db40ec22bc94"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("ecb30191-c049-4acc-b84f-0dc2b363d31c"));

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("72714910-0381-4fd4-a76c-b107ac632867"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", "Black Widow" });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("b70f39c2-8277-4fe5-9f31-39e84ebd5f0b"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", "Batman" });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("b80667a3-06b0-4ba0-bd3f-0599e5fb378c"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", "Luke Skywalker" });
        }
    }
}
