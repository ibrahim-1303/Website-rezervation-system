﻿// <auto-generated />
using System;
using Güzellik_Merkezi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Güzellik_Merkezi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Güzellik_Merkezi.Models.AppRol", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Güzellik_Merkezi.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("KuaförRandevu00.Models.Hizmetler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Fiyat1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Fiyat2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Fiyat3")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Fiyat4")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Hizmet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hizmet1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hizmet2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hizmet3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hizmet4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResimYolu")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Hizmetlers");
                });

            modelBuilder.Entity("KuaförRandevu00.Models.HomePage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Aciklama1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AciklamaDigerSacStilleri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AciklamaKaliteliSacKesimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BaslikAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BaslikDigerSacStilleri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BaslikKaliteliSacKesimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BaslikServisler")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoYazısı")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResimYolu")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ResimYolu1")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ResimYolu2")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ResimYolu3")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ResimYolu4")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ServislerBasli")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SrvislerAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HomePages");
                });

            modelBuilder.Entity("KuaförRandevu00.Models.Randevu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<string>("Telno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Randevus");
                });

            modelBuilder.Entity("KuaförRandevu00.Models.Servis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Aciklama1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Aciklama2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Aciklama3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Aciklama4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Aciklama5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Aciklama6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientSaysAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientSaysbaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KalitelisacAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KalitelisacBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoYazısı")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MüsteriAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MüsteriAciklama2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MüsteriAciklama3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Müsteriisim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Müsteriisim2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Müsteriisim3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResimYolu")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ResimYolu1")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ResimYolu2")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ResimYolu3")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Servislers");
                });

            modelBuilder.Entity("KuaförRandevu00.Models.İletisim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Aciklama1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EPosta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoYazısı")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("İletisims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Güzellik_Merkezi.Models.AppRol", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Güzellik_Merkezi.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Güzellik_Merkezi.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Güzellik_Merkezi.Models.AppRol", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Güzellik_Merkezi.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Güzellik_Merkezi.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
