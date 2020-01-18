using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace eThreadingBar.WebAPI.Database
{
    public partial class BeautyStudio2019Context : DbContext
    {
        public BeautyStudio2019Context()
        {
        }

        public BeautyStudio2019Context(DbContextOptions<BeautyStudio2019Context> options)
            : base(options)
        {
        }

        public virtual DbSet<ClanciKategorija> ClanciKategorija { get; set; }
        public virtual DbSet<Clank> Clank { get; set; }
        public virtual DbSet<Grad> Grad { get; set; }
        public virtual DbSet<Klijent> Klijent { get; set; }
        public virtual DbSet<KlijentNotifikacija> KlijentNotifikacija { get; set; }
        public virtual DbSet<KorisniciUloge> KorisniciUloge { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<Nagrada> Nagrada { get; set; }
        public virtual DbSet<NagradnaIgra> NagradnaIgra { get; set; }
        public virtual DbSet<PoslataNotifikacija> PoslataNotifikacija { get; set; }
        public virtual DbSet<Rezervacija> Rezervacija { get; set; }
        public virtual DbSet<Termin> Termin { get; set; }
        public virtual DbSet<Tretman> Tretman { get; set; }
        public virtual DbSet<Uloga> Uloga { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=BeautyStudio2019;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<ClanciKategorija>(entity =>
            {
                entity.Property(e => e.ClanciKategorijaId).HasColumnName("ClanciKategorijaID");
            });

            modelBuilder.Entity<Clank>(entity =>
            {
                entity.HasKey(e => e.ClanakId);

                entity.HasIndex(e => e.ClanciKategorijaId);

                entity.Property(e => e.ClanakId).HasColumnName("ClanakID");

                entity.Property(e => e.ClanciKategorijaId).HasColumnName("ClanciKategorijaID");

                entity.Property(e => e.Slika).HasColumnType("image");

                entity.HasOne(d => d.ClanciKategorija)
                    .WithMany(p => p.Clank)
                    .HasForeignKey(d => d.ClanciKategorijaId);

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Clank)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK_Clanak_Korisnik_Id");
            });

            modelBuilder.Entity<Klijent>(entity =>
            {
                entity.HasIndex(e => e.GradId);

                entity.Property(e => e.KlijentId).HasColumnName("KlijentID");

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.KorisnickoIme).HasMaxLength(50);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Klijent)
                    .HasForeignKey(d => d.GradId);
            });

            modelBuilder.Entity<KlijentNotifikacija>(entity =>
            {
                entity.HasKey(e => e.NotifikacijaId)
                    .HasName("PK_NotifikacijaId");

                entity.Property(e => e.DatumSlanja).HasColumnType("datetime");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.KlijentNotifikacija)
                    .HasForeignKey(d => d.KlijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notifikacija_KlijentId");

                entity.HasOne(d => d.Rezervacija)
                    .WithMany(p => p.KlijentNotifikacija)
                    .HasForeignKey(d => d.RezervacijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notifikacija_RezervacijaId");
            });

            modelBuilder.Entity<KorisniciUloge>(entity =>
            {
                entity.HasKey(e => e.KorisnikUlogaId)
                    .HasName("PK__Korisnic__1608726EE9BC7CF0");

                entity.Property(e => e.DatumIzmjene).HasColumnType("datetime");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK_KorisnikId");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.UlogaId)
                    .HasConstraintName("FK_UlogaId");
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.Property(e => e.Slika).HasColumnType("image");
            });

            modelBuilder.Entity<Nagrada>(entity =>
            {
                entity.Property(e => e.NagradaId).HasColumnName("NagradaID");

                entity.Property(e => e.Photo).HasColumnType("image");
            });

            modelBuilder.Entity<NagradnaIgra>(entity =>
            {
                entity.HasIndex(e => e.KlijentId);

                entity.HasIndex(e => e.NagradaId);

                entity.Property(e => e.NagradnaIgraId).HasColumnName("NagradnaIgraID");

                entity.Property(e => e.KlijentId).HasColumnName("KlijentID");

                entity.Property(e => e.NagradaId).HasColumnName("NagradaID");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.NagradnaIgra)
                    .HasForeignKey(d => d.KlijentId);

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.NagradnaIgra)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK_NagradnaIgra_KlijentId");

                entity.HasOne(d => d.Nagrada)
                    .WithMany(p => p.NagradnaIgra)
                    .HasForeignKey(d => d.NagradaId);
            });

            modelBuilder.Entity<PoslataNotifikacija>(entity =>
            {
                entity.HasIndex(e => e.RezervacijaId);

                entity.HasOne(d => d.Rezervacija)
                    .WithMany(p => p.PoslataNotifikacija)
                    .HasForeignKey(d => d.RezervacijaId);
            });

            modelBuilder.Entity<Rezervacija>(entity =>
            {
                entity.HasIndex(e => e.KlijentId);

                entity.HasIndex(e => e.TerminId);

                entity.HasIndex(e => e.TretmanId);

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Rezervacija)
                    .HasForeignKey(d => d.KlijentId);

                entity.HasOne(d => d.Termin)
                    .WithMany(p => p.Rezervacija)
                    .HasForeignKey(d => d.TerminId);

                entity.HasOne(d => d.Tretman)
                    .WithMany(p => p.Rezervacija)
                    .HasForeignKey(d => d.TretmanId);
            });

            modelBuilder.Entity<Termin>(entity =>
            {
                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Termin)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK_Termin_Korisnik_Id");
            });

            modelBuilder.Entity<Tretman>(entity =>
            {
                entity.Property(e => e.TretmanId).HasColumnName("TretmanID");

                entity.Property(e => e.Naziv).IsRequired();
            });
        }
    }
}
