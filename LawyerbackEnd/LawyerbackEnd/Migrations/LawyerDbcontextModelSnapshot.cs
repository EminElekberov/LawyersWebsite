﻿// <auto-generated />
using System;
using LawyerbackEnd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LawyerbackEnd.Migrations
{
    [DbContext(typeof(LawyerDbcontext))]
    partial class LawyerDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("LawyerbackEnd.Models.AllContactsAreas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressHeader")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactHeader")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactHeaderDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("Hours")
                        .HasColumnType("TEXT");

                    b.Property<string>("OfficeHeader")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneHeader")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AllContactsAreas");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.AttorneyWork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ButtonLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("Buttontext")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Header")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AttorneyWorks");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.AttorneysLogo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AttorneysLogos");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.AttorneysSlider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AttorneysSliders");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.Biography", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Aphorizm")
                        .HasColumnType("TEXT");

                    b.Property<string>("AwardDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AwardIconsDesc")
                        .HasColumnType("TEXT");

                    b.Property<string>("AwarsHeader")
                        .HasColumnType("TEXT");

                    b.Property<string>("BioDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BioHeader")
                        .HasColumnType("TEXT");

                    b.Property<string>("Comminucate")
                        .HasColumnType("TEXT");

                    b.Property<string>("EducationDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EducationHeader")
                        .HasColumnType("TEXT");

                    b.Property<string>("IconsComminucate")
                        .HasColumnType("TEXT");

                    b.Property<string>("IconsComminucate2")
                        .HasColumnType("TEXT");

                    b.Property<string>("IconsComminucate3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("Job")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PractiseHeader")
                        .HasColumnType("TEXT");

                    b.Property<string>("PrcatiseDesc")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Biographies");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.BlogDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AboutDesc")
                        .HasColumnType("TEXT");

                    b.Property<string>("AphirzmWriter")
                        .HasColumnType("TEXT");

                    b.Property<string>("Aphorizm")
                        .HasColumnType("TEXT");

                    b.Property<string>("ButtonLink1")
                        .HasColumnType("TEXT");

                    b.Property<string>("ButtonLink2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Buttontext1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Buttontext2")
                        .HasColumnType("TEXT");

                    b.Property<string>("CateagoriesTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoriesDesc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT");

                    b.Property<string>("Dates")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Header")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("RecentDesc")
                        .HasColumnType("TEXT");

                    b.Property<string>("RecentTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("headerDesc")
                        .HasColumnType("TEXT");

                    b.Property<string>("titleDesc")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BlogDetails");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.BlogHeader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("header")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BlogHeaders");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.BlogIndexAbout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ABoutDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("AboutHeadder")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryHEader")
                        .HasColumnType("TEXT");

                    b.Property<string>("RecentDesc")
                        .HasColumnType("TEXT");

                    b.Property<string>("RecetHeader")
                        .HasColumnType("TEXT");

                    b.Property<string>("catgoryDesc")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BlogIndexAbouts");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.Case", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Challenge")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("LawherFullname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Result")
                        .HasColumnType("TEXT");

                    b.Property<string>("Solution")
                        .HasColumnType("TEXT");

                    b.Property<int>("Time")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int>("categorysId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("categorysId");

                    b.ToTable("Cases");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.Categorys", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("className")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.Components", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .HasColumnType("TEXT");

                    b.Property<string>("MyOpinion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("ReadyForm")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Subject")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.Faq", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question4")
                        .HasColumnType("TEXT");

                    b.Property<string>("QuestionText3")
                        .HasColumnType("TEXT");

                    b.Property<string>("QuestionText4")
                        .HasColumnType("TEXT");

                    b.Property<string>("Questiontext1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Questiontext2")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Faqs");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.Holder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Holders");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.IndexChoose", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TextTwo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Textone")
                        .HasColumnType("TEXT");

                    b.Property<string>("numbFourDesc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("numberFour")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("numberOne")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("numberThree")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("numberTwo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("numbrTWoDesc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("numbrThreeDesc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("numbroneDesc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("IndexChooses");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ButtonOneLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("ButtonOnetext")
                        .HasColumnType("TEXT");

                    b.Property<string>("ButtonTwoLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("ButtonTwotext")
                        .HasColumnType("TEXT");

                    b.Property<string>("Dates")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.OurAbout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Dates")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("headerUndeer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("OurAbouts");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.Packet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Packets");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.PacketToComponents", b =>
                {
                    b.Property<int>("PacketId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("componentsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PacketId", "componentsId");

                    b.HasIndex("componentsId");

                    b.ToTable("packetToComponents");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.PageContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Header")
                        .HasColumnType("TEXT");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LinkDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PageContacts");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.PageSlider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PageSliders");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.PictureSlider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("pictureSliders");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.PracticeAbout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("IconLink")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LearnLink")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Learntext")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PracticeAbouts");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.PracticeSlider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PracticeSliders");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.Practise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Practises");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ButtonLink")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Buttontext")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Sliders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Moto Car",
                            Image = "slider1.jpeg",
                            Name = "We provide legal"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Auto Accidents",
                            Image = "slider2.jpeg",
                            Name = "We provide legal"
                        });
                });

            modelBuilder.Entity("LawyerbackEnd.Models.Teams", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SocialNetworkLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("SocialNetworkLink2")
                        .HasColumnType("TEXT");

                    b.Property<string>("SocialNetworkLink3")
                        .HasColumnType("TEXT");

                    b.Property<string>("SocialNetworkLink4")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("LawyerbackEnd.Models.Case", b =>
                {
                    b.HasOne("LawyerbackEnd.Models.Categorys", "categorys")
                        .WithMany("Cases")
                        .HasForeignKey("categorysId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LawyerbackEnd.Models.PacketToComponents", b =>
                {
                    b.HasOne("LawyerbackEnd.Models.Packet", "packet")
                        .WithMany("packetToComponents")
                        .HasForeignKey("PacketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LawyerbackEnd.Models.Components", "components")
                        .WithMany("PacketToComponents")
                        .HasForeignKey("componentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("LawyerbackEnd.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LawyerbackEnd.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LawyerbackEnd.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("LawyerbackEnd.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
