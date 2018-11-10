﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SupplyBlockChain_Backend.Data;

namespace SupplyBlockChain_Backend.Migrations
{
    [DbContext(typeof(BlockChainsDbContext))]
    [Migration("20181110102844_BlockChainMigration")]
    partial class BlockChainMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("SupplyBlockChain_Backend.Models.StoreBlockChains", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Difficulty");

                    b.Property<string>("SupplyBlockChain");

                    b.Property<string>("Verifier_1BlockChain");

                    b.Property<string>("Verifier_2BlockChain");

                    b.Property<string>("Verifier_3BlockChain");

                    b.HasKey("ID");

                    b.ToTable("AllBlockChains");
                });
#pragma warning restore 612, 618
        }
    }
}
