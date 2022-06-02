﻿// <auto-generated />
using System;
using GraphQLSample.Context.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GraphQLSample.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GraphQLSample.Model.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Project", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("7d176e83-67de-4ff3-981d-f72fe107f1bc"),
                            Description = "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.",
                            Name = "Batman"
                        },
                        new
                        {
                            Id = new Guid("c87b8af0-f7b2-4427-b01f-db40ec22bc94"),
                            Description = "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.",
                            Name = "Luke Skywalker"
                        },
                        new
                        {
                            Id = new Guid("ecb30191-c049-4acc-b84f-0dc2b363d31c"),
                            Description = "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.",
                            Name = "Black Widow"
                        });
                });

            modelBuilder.Entity("GraphQLSample.Model.SHPViewDlogWithAudit", b =>
                {
                    b.Property<string>("SBSB_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AFFILIATION")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BF_COV_EFF_DT")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BF_EXP_DT")
                        .HasColumnType("datetime2");

                    b.Property<string>("BF_FILE_TYPE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BF_PVSR_CITY")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BF_PVSR_FNAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BF_PVSR_LNAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BF_TRANS_TYPE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CSCS_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CSPD_CAT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CSPI_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMAX_ATTACHMENT_TRIGGER")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IMAX_BATCH_ID")
                        .HasColumnType("int");

                    b.Property<string>("IMAX_BENEFIT_TYPE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMAX_COB_TRIGGER")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMAX_COVERAGE_INDICATOR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMAX_ELIGIBILITY_RSN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("IMAX_ELIG_DT")
                        .HasColumnType("datetime2");

                    b.Property<string>("IMAX_ERROR_MSG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMAX_GROUP_IDENTIFIER")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMAX_HICN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMAX_MEDICARE_TYPE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMAX_NEW_MEMBER_TRIGGER")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMAX_PCP_CODE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("IMAX_PCP_EFF_DT")
                        .HasColumnType("datetime2");

                    b.Property<string>("IMAX_PCP_GROUP_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMAX_PCP_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMAX_PCP_SERVICE_LOC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMAX_PCP_TRIGGER")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMAX_PRODUCT_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMAX_PRPR_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMAX_SGSG_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMAX_SUBGRP_CHG_TRIGGER")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMAX_TRANSACTION_TYPE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMAX_TRANS_STATE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("KEY_EFF_DT")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KEY_TERM_DT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MCTR_TRSN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MEMBER_ADDR_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MEME_BIRTH_DT")
                        .HasColumnType("datetime2");

                    b.Property<int>("MEME_CK")
                        .HasColumnType("int");

                    b.Property<string>("MEME_FIRST_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MEME_LAST_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MEME_MID_INIT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MEME_REL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MEME_SEX")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MEME_SFX")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MEME_SSN")
                        .HasColumnType("int");

                    b.Property<DateTime>("MEPE_EFF_DT")
                        .HasColumnType("datetime2");

                    b.Property<string>("MEPE_ELIG_IND")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MEPE_TERM_DT")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MEPR_EFF_DT")
                        .HasColumnType("datetime2");

                    b.Property<string>("MEPR_MCTR_ORSN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MEPR_MCTR_TRSN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MEPR_PCP_TYPE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MEPR_TERM_DT")
                        .HasColumnType("datetime2");

                    b.Property<string>("PRPR_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provider_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SBAD_ADDR_1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SBAD_ADDR_2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SBAD_CITY")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SBAD_COUNTRY")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SBAD_COUNTY")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SBAD_STATE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SBAD_ZIP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SGSG_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SGSG_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TRANSACTION_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("XMS_FAM_SEQ_NO")
                        .HasColumnType("int");

                    b.Property<string>("XMS_FILE_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SBSB_ID");

                    b.ToTable("SHPViewDlogWithAudit", (string)null);

                    b.HasData(
                        new
                        {
                            SBSB_ID = "651682e2-b373-4c4b-9ae0-34eb1183907f",
                            AFFILIATION = "",
                            BF_COV_EFF_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BF_EXP_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BF_FILE_TYPE = "",
                            BF_PVSR_CITY = "",
                            BF_PVSR_FNAME = "",
                            BF_PVSR_LNAME = "",
                            BF_TRANS_TYPE = "",
                            CSCS_ID = "",
                            CSPD_CAT = "",
                            CSPI_ID = "",
                            Details = "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.",
                            IMAX_ATTACHMENT_TRIGGER = "",
                            IMAX_BATCH_ID = 1,
                            IMAX_BENEFIT_TYPE = "",
                            IMAX_COB_TRIGGER = "",
                            IMAX_COVERAGE_INDICATOR = "",
                            IMAX_ELIGIBILITY_RSN = "",
                            IMAX_ELIG_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IMAX_ERROR_MSG = "",
                            IMAX_GROUP_IDENTIFIER = "",
                            IMAX_HICN = "",
                            IMAX_MEDICARE_TYPE = "",
                            IMAX_NEW_MEMBER_TRIGGER = "",
                            IMAX_PCP_CODE = "",
                            IMAX_PCP_EFF_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IMAX_PCP_GROUP_ID = "",
                            IMAX_PCP_NAME = "",
                            IMAX_PCP_SERVICE_LOC = "",
                            IMAX_PCP_TRIGGER = "",
                            IMAX_PRODUCT_ID = "",
                            IMAX_PRPR_ID = "",
                            IMAX_SGSG_NAME = "",
                            IMAX_SUBGRP_CHG_TRIGGER = "",
                            IMAX_TRANSACTION_TYPE = "",
                            IMAX_TRANS_STATE = "",
                            KEY_EFF_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KEY_TERM_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location_Id = "",
                            MCTR_TRSN = "",
                            MEMBER_ADDR_ID = "",
                            MEME_BIRTH_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MEME_CK = 1,
                            MEME_FIRST_NAME = "Batman",
                            MEME_LAST_NAME = "",
                            MEME_MID_INIT = "",
                            MEME_REL = "",
                            MEME_SEX = "",
                            MEME_SFX = "",
                            MEME_SSN = 1,
                            MEPE_EFF_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MEPE_ELIG_IND = "",
                            MEPE_TERM_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MEPR_EFF_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MEPR_MCTR_ORSN = "",
                            MEPR_MCTR_TRSN = "",
                            MEPR_PCP_TYPE = "",
                            MEPR_TERM_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PRPR_ID = "",
                            Provider_Id = "",
                            SBAD_ADDR_1 = "",
                            SBAD_ADDR_2 = "",
                            SBAD_CITY = "",
                            SBAD_COUNTRY = "",
                            SBAD_COUNTY = "",
                            SBAD_STATE = "",
                            SBAD_ZIP = "",
                            SGSG_ID = "",
                            SGSG_NAME = "",
                            TRANSACTION_DATE = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            XMS_FAM_SEQ_NO = 1,
                            XMS_FILE_ID = ""
                        },
                        new
                        {
                            SBSB_ID = "b52fdcfb-080d-4f3a-93b0-95939993b59c",
                            AFFILIATION = "",
                            BF_COV_EFF_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BF_EXP_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BF_FILE_TYPE = "",
                            BF_PVSR_CITY = "",
                            BF_PVSR_FNAME = "",
                            BF_PVSR_LNAME = "",
                            BF_TRANS_TYPE = "",
                            CSCS_ID = "",
                            CSPD_CAT = "",
                            CSPI_ID = "",
                            Details = "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.",
                            IMAX_ATTACHMENT_TRIGGER = "",
                            IMAX_BATCH_ID = 1,
                            IMAX_BENEFIT_TYPE = "",
                            IMAX_COB_TRIGGER = "",
                            IMAX_COVERAGE_INDICATOR = "",
                            IMAX_ELIGIBILITY_RSN = "",
                            IMAX_ELIG_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IMAX_ERROR_MSG = "",
                            IMAX_GROUP_IDENTIFIER = "",
                            IMAX_HICN = "",
                            IMAX_MEDICARE_TYPE = "",
                            IMAX_NEW_MEMBER_TRIGGER = "",
                            IMAX_PCP_CODE = "",
                            IMAX_PCP_EFF_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IMAX_PCP_GROUP_ID = "",
                            IMAX_PCP_NAME = "",
                            IMAX_PCP_SERVICE_LOC = "",
                            IMAX_PCP_TRIGGER = "",
                            IMAX_PRODUCT_ID = "",
                            IMAX_PRPR_ID = "",
                            IMAX_SGSG_NAME = "",
                            IMAX_SUBGRP_CHG_TRIGGER = "",
                            IMAX_TRANSACTION_TYPE = "",
                            IMAX_TRANS_STATE = "",
                            KEY_EFF_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KEY_TERM_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location_Id = "",
                            MCTR_TRSN = "",
                            MEMBER_ADDR_ID = "",
                            MEME_BIRTH_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MEME_CK = 1,
                            MEME_FIRST_NAME = "Luke Skywalker",
                            MEME_LAST_NAME = "",
                            MEME_MID_INIT = "",
                            MEME_REL = "",
                            MEME_SEX = "",
                            MEME_SFX = "",
                            MEME_SSN = 1,
                            MEPE_EFF_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MEPE_ELIG_IND = "",
                            MEPE_TERM_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MEPR_EFF_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MEPR_MCTR_ORSN = "",
                            MEPR_MCTR_TRSN = "",
                            MEPR_PCP_TYPE = "",
                            MEPR_TERM_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PRPR_ID = "",
                            Provider_Id = "",
                            SBAD_ADDR_1 = "",
                            SBAD_ADDR_2 = "",
                            SBAD_CITY = "",
                            SBAD_COUNTRY = "",
                            SBAD_COUNTY = "",
                            SBAD_STATE = "",
                            SBAD_ZIP = "",
                            SGSG_ID = "",
                            SGSG_NAME = "",
                            TRANSACTION_DATE = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            XMS_FAM_SEQ_NO = 1,
                            XMS_FILE_ID = ""
                        },
                        new
                        {
                            SBSB_ID = "a390f402-25a6-4a13-ba48-237771f66ce4",
                            AFFILIATION = "",
                            BF_COV_EFF_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BF_EXP_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BF_FILE_TYPE = "",
                            BF_PVSR_CITY = "",
                            BF_PVSR_FNAME = "",
                            BF_PVSR_LNAME = "",
                            BF_TRANS_TYPE = "",
                            CSCS_ID = "",
                            CSPD_CAT = "",
                            CSPI_ID = "",
                            Details = "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.",
                            IMAX_ATTACHMENT_TRIGGER = "",
                            IMAX_BATCH_ID = 1,
                            IMAX_BENEFIT_TYPE = "",
                            IMAX_COB_TRIGGER = "",
                            IMAX_COVERAGE_INDICATOR = "",
                            IMAX_ELIGIBILITY_RSN = "",
                            IMAX_ELIG_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IMAX_ERROR_MSG = "",
                            IMAX_GROUP_IDENTIFIER = "",
                            IMAX_HICN = "",
                            IMAX_MEDICARE_TYPE = "",
                            IMAX_NEW_MEMBER_TRIGGER = "",
                            IMAX_PCP_CODE = "",
                            IMAX_PCP_EFF_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IMAX_PCP_GROUP_ID = "",
                            IMAX_PCP_NAME = "",
                            IMAX_PCP_SERVICE_LOC = "",
                            IMAX_PCP_TRIGGER = "",
                            IMAX_PRODUCT_ID = "",
                            IMAX_PRPR_ID = "",
                            IMAX_SGSG_NAME = "",
                            IMAX_SUBGRP_CHG_TRIGGER = "",
                            IMAX_TRANSACTION_TYPE = "",
                            IMAX_TRANS_STATE = "",
                            KEY_EFF_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KEY_TERM_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location_Id = "",
                            MCTR_TRSN = "",
                            MEMBER_ADDR_ID = "",
                            MEME_BIRTH_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MEME_CK = 1,
                            MEME_FIRST_NAME = "Black Widow",
                            MEME_LAST_NAME = "",
                            MEME_MID_INIT = "",
                            MEME_REL = "",
                            MEME_SEX = "",
                            MEME_SFX = "",
                            MEME_SSN = 1,
                            MEPE_EFF_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MEPE_ELIG_IND = "",
                            MEPE_TERM_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MEPR_EFF_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MEPR_MCTR_ORSN = "",
                            MEPR_MCTR_TRSN = "",
                            MEPR_PCP_TYPE = "",
                            MEPR_TERM_DT = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PRPR_ID = "",
                            Provider_Id = "",
                            SBAD_ADDR_1 = "",
                            SBAD_ADDR_2 = "",
                            SBAD_CITY = "",
                            SBAD_COUNTRY = "",
                            SBAD_COUNTY = "",
                            SBAD_STATE = "",
                            SBAD_ZIP = "",
                            SGSG_ID = "",
                            SGSG_NAME = "",
                            TRANSACTION_DATE = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            XMS_FAM_SEQ_NO = 1,
                            XMS_FILE_ID = ""
                        });
                });
#pragma warning restore 612, 618
        }
    }
}