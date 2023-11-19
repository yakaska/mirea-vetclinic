﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using mirea_vetclinic.Domain;

#nullable disable

namespace mirea_vetclinic.Migrations
{
    [DbContext(typeof(VetClinicContext))]
    [Migration("20231119132006_VisitAlter")]
    partial class VisitAlter
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("mirea_vetclinic.Domain.Models.Hostess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<string>("Patronymic")
                        .HasColumnType("text")
                        .HasColumnName("patronymic");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.HasKey("Id")
                        .HasName("pk_hostesses");

                    b.ToTable("hostesses", (string)null);
                });

            modelBuilder.Entity("mirea_vetclinic.Domain.Models.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<string>("Patronymic")
                        .HasColumnType("text")
                        .HasColumnName("patronymic");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.HasKey("Id")
                        .HasName("pk_owners");

                    b.ToTable("owners", (string)null);
                });

            modelBuilder.Entity("mirea_vetclinic.Domain.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer")
                        .HasColumnName("age");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nickname");

                    b.Property<int>("OwnerId")
                        .HasColumnType("integer")
                        .HasColumnName("owner_id");

                    b.Property<int>("Specie")
                        .HasColumnType("integer")
                        .HasColumnName("specie");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("status");

                    b.HasKey("Id")
                        .HasName("pk_pets");

                    b.HasIndex("OwnerId")
                        .HasDatabaseName("ix_pets_owner_id");

                    b.ToTable("pets", (string)null);
                });

            modelBuilder.Entity("mirea_vetclinic.Domain.Models.Procedure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ProcedureName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("procedure_name");

                    b.HasKey("Id")
                        .HasName("pk_procedures");

                    b.ToTable("procedures", (string)null);
                });

            modelBuilder.Entity("mirea_vetclinic.Domain.Models.Specialty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("SpecialtyName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("specialty_name");

                    b.HasKey("Id")
                        .HasName("pk_specialties");

                    b.ToTable("specialties", (string)null);
                });

            modelBuilder.Entity("mirea_vetclinic.Domain.Models.Vet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<string>("Patronymic")
                        .HasColumnType("text")
                        .HasColumnName("patronymic");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.HasKey("Id")
                        .HasName("pk_vets");

                    b.ToTable("vets", (string)null);
                });

            modelBuilder.Entity("mirea_vetclinic.Domain.Models.VetSpecialties", b =>
                {
                    b.Property<int>("VetId")
                        .HasColumnType("integer")
                        .HasColumnName("vet_id");

                    b.Property<int>("SpecialtyId")
                        .HasColumnType("integer")
                        .HasColumnName("specialty_id");

                    b.HasKey("VetId", "SpecialtyId")
                        .HasName("pk_vet_specialties");

                    b.HasIndex("SpecialtyId")
                        .HasDatabaseName("ix_vet_specialties_specialty_id");

                    b.ToTable("vet_specialties", (string)null);
                });

            modelBuilder.Entity("mirea_vetclinic.Domain.Models.Visit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date");

                    b.Property<int>("HostessId")
                        .HasColumnType("integer")
                        .HasColumnName("hostess_id");

                    b.Property<int>("OwnerId")
                        .HasColumnType("integer")
                        .HasColumnName("owner_id");

                    b.Property<int>("PetId")
                        .HasColumnType("integer")
                        .HasColumnName("pet_id");

                    b.Property<int>("VetId")
                        .HasColumnType("integer")
                        .HasColumnName("vet_id");

                    b.HasKey("Id")
                        .HasName("pk_visits");

                    b.HasIndex("HostessId")
                        .HasDatabaseName("ix_visits_hostess_id");

                    b.HasIndex("OwnerId")
                        .HasDatabaseName("ix_visits_owner_id");

                    b.HasIndex("PetId")
                        .HasDatabaseName("ix_visits_pet_id");

                    b.HasIndex("VetId")
                        .HasDatabaseName("ix_visits_vet_id");

                    b.ToTable("visits", (string)null);
                });

            modelBuilder.Entity("mirea_vetclinic.Domain.Models.VisitProcedures", b =>
                {
                    b.Property<int>("VisitId")
                        .HasColumnType("integer")
                        .HasColumnName("visit_id");

                    b.Property<int>("ProcedureId")
                        .HasColumnType("integer")
                        .HasColumnName("procedure_id");

                    b.HasKey("VisitId", "ProcedureId")
                        .HasName("pk_visit_procedures");

                    b.HasIndex("ProcedureId")
                        .HasDatabaseName("ix_visit_procedures_procedure_id");

                    b.ToTable("visit_procedures", (string)null);
                });

            modelBuilder.Entity("mirea_vetclinic.Domain.Models.Pet", b =>
                {
                    b.HasOne("mirea_vetclinic.Domain.Models.Owner", "Owner")
                        .WithMany("Pets")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_pets_owners_owner_id");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("mirea_vetclinic.Domain.Models.VetSpecialties", b =>
                {
                    b.HasOne("mirea_vetclinic.Domain.Models.Specialty", "Specialty")
                        .WithMany("VetSpecialties")
                        .HasForeignKey("SpecialtyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_vet_specialties_specialties_specialty_id");

                    b.HasOne("mirea_vetclinic.Domain.Models.Vet", "Vet")
                        .WithMany("VetSpecialties")
                        .HasForeignKey("VetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_vet_specialties_vets_vet_id");

                    b.Navigation("Specialty");

                    b.Navigation("Vet");
                });

            modelBuilder.Entity("mirea_vetclinic.Domain.Models.Visit", b =>
                {
                    b.HasOne("mirea_vetclinic.Domain.Models.Hostess", "Hostess")
                        .WithMany("Appointments")
                        .HasForeignKey("HostessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_visits_hostesses_hostess_id");

                    b.HasOne("mirea_vetclinic.Domain.Models.Owner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_visits_owners_owner_id");

                    b.HasOne("mirea_vetclinic.Domain.Models.Pet", "Pet")
                        .WithMany("Visits")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_visits_pets_pet_id");

                    b.HasOne("mirea_vetclinic.Domain.Models.Vet", "Vet")
                        .WithMany("Visits")
                        .HasForeignKey("VetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_visits_vets_vet_id");

                    b.Navigation("Hostess");

                    b.Navigation("Owner");

                    b.Navigation("Pet");

                    b.Navigation("Vet");
                });

            modelBuilder.Entity("mirea_vetclinic.Domain.Models.VisitProcedures", b =>
                {
                    b.HasOne("mirea_vetclinic.Domain.Models.Procedure", "Procedure")
                        .WithMany("VisitProcedures")
                        .HasForeignKey("ProcedureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_visit_procedures_procedures_procedure_id");

                    b.HasOne("mirea_vetclinic.Domain.Models.Visit", "Visit")
                        .WithMany("VisitProcedures")
                        .HasForeignKey("VisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_visit_procedures_visits_visit_id");

                    b.Navigation("Procedure");

                    b.Navigation("Visit");
                });

            modelBuilder.Entity("mirea_vetclinic.Domain.Models.Hostess", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("mirea_vetclinic.Domain.Models.Owner", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("mirea_vetclinic.Domain.Models.Pet", b =>
                {
                    b.Navigation("Visits");
                });

            modelBuilder.Entity("mirea_vetclinic.Domain.Models.Procedure", b =>
                {
                    b.Navigation("VisitProcedures");
                });

            modelBuilder.Entity("mirea_vetclinic.Domain.Models.Specialty", b =>
                {
                    b.Navigation("VetSpecialties");
                });

            modelBuilder.Entity("mirea_vetclinic.Domain.Models.Vet", b =>
                {
                    b.Navigation("VetSpecialties");

                    b.Navigation("Visits");
                });

            modelBuilder.Entity("mirea_vetclinic.Domain.Models.Visit", b =>
                {
                    b.Navigation("VisitProcedures");
                });
#pragma warning restore 612, 618
        }
    }
}
