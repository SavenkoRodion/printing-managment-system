using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PMS_Api.Model;

public partial class VeraprintContext : DbContext
{
    public VeraprintContext()
    {
    }

    public VeraprintContext(DbContextOptions<VeraprintContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdresyDostaw> AdresyDostaws { get; set; }

    public virtual DbSet<Cennik> Cenniks { get; set; }

    public virtual DbSet<CennikPrzesylek> CennikPrzesyleks { get; set; }

    public virtual DbSet<CennikPrzesylekKlientow> CennikPrzesylekKlientows { get; set; }

    public virtual DbSet<Cenniki> Cennikis { get; set; }

    public virtual DbSet<CentraKosztowe> CentraKosztowes { get; set; }

    public virtual DbSet<CentraNazwy> CentraNazwies { get; set; }

    public virtual DbSet<CentraWybrane> CentraWybranes { get; set; }

    public virtual DbSet<Czcionki> Czcionkis { get; set; }

    public virtual DbSet<Danetestowe> Danetestowes { get; set; }

    public virtual DbSet<Email> Emails { get; set; }

    public virtual DbSet<Etykietyproduktyzapisane> Etykietyproduktyzapisanes { get; set; }

    public virtual DbSet<Faktura> Fakturas { get; set; }

    public virtual DbSet<FakturaZalacznik> FakturaZalaczniks { get; set; }

    public virtual DbSet<Filtry> Filtries { get; set; }

    public virtual DbSet<Formaty> Formaties { get; set; }

    public virtual DbSet<Identyfikatory> Identyfikatories { get; set; }

    public virtual DbSet<KampaniaMailingowa> KampaniaMailingowas { get; set; }

    public virtual DbSet<KampaniaMailingowaStatystyka> KampaniaMailingowaStatystykas { get; set; }

    public virtual DbSet<Kategorie> Kategories { get; set; }

    public virtual DbSet<Klienci> Kliencis { get; set; }

    public virtual DbSet<Klientcennik> Klientcenniks { get; set; }

    public virtual DbSet<KodyProgramPartnerski> KodyProgramPartnerskis { get; set; }

    public virtual DbSet<Komentarzeproduktyzamowienie> Komentarzeproduktyzamowienies { get; set; }

    public virtual DbSet<KonfiguracjaUzytkownika> KonfiguracjaUzytkownikas { get; set; }

    public virtual DbSet<Konfiguracjaczcionek> Konfiguracjaczcioneks { get; set; }

    public virtual DbSet<Konkursy> Konkursies { get; set; }

    public virtual DbSet<KontaBankoweKonfiguracja> KontaBankoweKonfiguracjas { get; set; }

    public virtual DbSet<Kontrahenci> Kontrahencis { get; set; }

    public virtual DbSet<KontrahenciWybrani> KontrahenciWybranis { get; set; }

    public virtual DbSet<Koszyk> Koszyks { get; set; }

    public virtual DbSet<Kraje> Krajes { get; set; }

    public virtual DbSet<Kryteriasortowanium> Kryteriasortowania { get; set; }

    public virtual DbSet<Kuponyrabatowe> Kuponyrabatowes { get; set; }

    public virtual DbSet<Kuponyrabatowerezerwacja> Kuponyrabatowerezerwacjas { get; set; }

    public virtual DbSet<Logasadmin> Logasadmins { get; set; }

    public virtual DbSet<Newsletteruzytkownicy> Newsletteruzytkownicies { get; set; }

    public virtual DbSet<Opinie> Opinies { get; set; }

    public virtual DbSet<Paczkomaty> Paczkomaties { get; set; }

    public virtual DbSet<PaczkomatyKonfiguracja> PaczkomatyKonfiguracjas { get; set; }

    public virtual DbSet<Papier> Papiers { get; set; }

    public virtual DbSet<ParametryProduktow> ParametryProduktows { get; set; }

    public virtual DbSet<Podkategorie> Podkategories { get; set; }

    public virtual DbSet<Podkategorieseo> Podkategorieseos { get; set; }

    public virtual DbSet<Probkidrukow> Probkidrukows { get; set; }

    public virtual DbSet<Produkty> Produkties { get; set; }

    public virtual DbSet<Produkty7dniowe> Produkty7dniowes { get; set; }

    public virtual DbSet<ProduktyKlientow> ProduktyKlientows { get; set; }

    public virtual DbSet<ProduktyParametry> ProduktyParametries { get; set; }

    public virtual DbSet<ProduktyWartosci> ProduktyWartoscis { get; set; }

    public virtual DbSet<Produktyfaktura> Produktyfakturas { get; set; }

    public virtual DbSet<Produktyfirmowe> Produktyfirmowes { get; set; }

    public virtual DbSet<Produktykoszyk> Produktykoszyks { get; set; }

    public virtual DbSet<Produktyzamowienie> Produktyzamowienies { get; set; }

    public virtual DbSet<Produktyzapisane> Produktyzapisanes { get; set; }

    public virtual DbSet<Produktyzapisaneakceptacja> Produktyzapisaneakceptacjas { get; set; }

    public virtual DbSet<Produktyzdefiniowane> Produktyzdefiniowanes { get; set; }

    public virtual DbSet<ProjektyKonkursowe> ProjektyKonkursowes { get; set; }

    public virtual DbSet<Przesylki> Przesylkis { get; set; }

    public virtual DbSet<PrzesylkiKonfiguracja> PrzesylkiKonfiguracjas { get; set; }

    public virtual DbSet<Przesylkizamowienium> Przesylkizamowienia { get; set; }

    public virtual DbSet<RodzajeDostawy> RodzajeDostawies { get; set; }

    public virtual DbSet<Rodzajemaili> Rodzajemailis { get; set; }

    public virtual DbSet<Rodzajepapieru> Rodzajepapierus { get; set; }

    public virtual DbSet<RozliczeniaListaZamowien> RozliczeniaListaZamowiens { get; set; }

    public virtual DbSet<Rozliczenium> Rozliczenia { get; set; }

    public virtual DbSet<SkrzynkaKontaktowa> SkrzynkaKontaktowas { get; set; }

    public virtual DbSet<Statystyka> Statystykas { get; set; }

    public virtual DbSet<StatystykiZamowien> StatystykiZamowiens { get; set; }

    public virtual DbSet<Stronastartowa> Stronastartowas { get; set; }

    public virtual DbSet<Szablonyopisseo> Szablonyopisseos { get; set; }

    public virtual DbSet<Szablonyproduktow> Szablonyproduktows { get; set; }

    public virtual DbSet<Tempimagegroup> Tempimagegroups { get; set; }

    public virtual DbSet<Uzytkownicy> Uzytkownicies { get; set; }

    public virtual DbSet<Uzytkownicysystemowi> Uzytkownicysystemowis { get; set; }

    public virtual DbSet<UzytkownikHasloTymczasowe> UzytkownikHasloTymczasowes { get; set; }

    public virtual DbSet<UzytkownikPrawa> UzytkownikPrawas { get; set; }

    public virtual DbSet<VideoPomoc> VideoPomocs { get; set; }

    public virtual DbSet<WartosciParametrow> WartosciParametrows { get; set; }

    public virtual DbSet<Zamowieniaobsluga> Zamowieniaobslugas { get; set; }

    public virtual DbSet<Zamowienie> Zamowienies { get; set; }

    public virtual DbSet<Zapytaniafirmaplu> Zapytaniafirmaplus { get; set; }

    public virtual DbSet<Zapytaniakontakt> Zapytaniakontakts { get; set; }

    public virtual DbSet<Zapytaniaofertowe> Zapytaniaofertowes { get; set; }

    public virtual DbSet<ZdaniaSynonimy> ZdaniaSynonimies { get; set; }

    public virtual DbSet<Zdanium> Zdania { get; set; }

    public virtual DbSet<Zrodlaodwiedzin> Zrodlaodwiedzins { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Server=localhost;Port=3307;Database=veraprint;uid=root;pwd=root;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdresyDostaw>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("adresy_dostaw");

            entity.HasIndex(e => e.UserId, "adresy_dostaw_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Adres)
                .HasMaxLength(255)
                .HasColumnName("adres");
            entity.Property(e => e.DomyslnyAdres)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("domyslny_adres");
            entity.Property(e => e.ImieNazwisko)
                .HasMaxLength(120)
                .HasColumnName("imie_nazwisko");
            entity.Property(e => e.KodPocztowy)
                .HasMaxLength(12)
                .HasColumnName("kod_pocztowy");
            entity.Property(e => e.Kraj)
                .HasMaxLength(6)
                .HasDefaultValueSql("'PL'")
                .HasColumnName("kraj");
            entity.Property(e => e.Miejscowosc)
                .HasMaxLength(255)
                .HasColumnName("miejscowosc");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(255)
                .HasColumnName("nazwa");
            entity.Property(e => e.NazwaFirmy)
                .HasMaxLength(255)
                .HasColumnName("nazwa_firmy");
            entity.Property(e => e.NrDomu)
                .HasMaxLength(10)
                .HasColumnName("nr_domu");
            entity.Property(e => e.NrMieszkania)
                .HasMaxLength(10)
                .HasColumnName("nr_mieszkania");
            entity.Property(e => e.Telefon)
                .HasMaxLength(20)
                .HasColumnName("telefon");
            entity.Property(e => e.Ulica)
                .HasMaxLength(255)
                .HasColumnName("ulica");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<Cennik>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cennik");

            entity.HasIndex(e => e.KategorieId, "cennik_FI_1");

            entity.HasIndex(e => e.FormatyId, "cennik_FI_2");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Domyslny)
                .HasColumnType("int(11)")
                .HasColumnName("domyslny");
            entity.Property(e => e.FormatyId)
                .HasColumnType("int(11)")
                .HasColumnName("formaty_id");
            entity.Property(e => e.KategorieId)
                .HasColumnType("int(11)")
                .HasColumnName("kategorie_id");
            entity.Property(e => e.Konfiguracja)
                .HasColumnType("text")
                .HasColumnName("konfiguracja");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(100)
                .HasColumnName("nazwa");
            entity.Property(e => e.Uid)
                .HasMaxLength(255)
                .HasColumnName("uid");
        });

        modelBuilder.Entity<CennikPrzesylek>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cennik_przesylek");

            entity.HasIndex(e => e.RodzajeDostawyId, "cennik_przesylek_FI_1");

            entity.HasIndex(e => e.KrajeId, "cennik_przesylek_FI_2");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Domyslna)
                .HasColumnType("tinyint(4)")
                .HasColumnName("domyslna");
            entity.Property(e => e.Kolejnosc)
                .HasColumnType("int(11)")
                .HasColumnName("kolejnosc");
            entity.Property(e => e.KrajeId)
                .HasColumnType("int(11)")
                .HasColumnName("kraje_id");
            entity.Property(e => e.KwotaBrutto)
                .HasMaxLength(20)
                .HasColumnName("kwota_brutto");
            entity.Property(e => e.RodzajeDostawyId)
                .HasColumnType("int(11)")
                .HasColumnName("rodzaje_dostawy_id");
            entity.Property(e => e.Waluta)
                .HasMaxLength(3)
                .HasColumnName("waluta");
        });

        modelBuilder.Entity<CennikPrzesylekKlientow>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cennik_przesylek_klientow");

            entity.HasIndex(e => e.RodzajeDostawyId, "cennik_przesylek_klientow_FI_1");

            entity.HasIndex(e => e.KrajeId, "cennik_przesylek_klientow_FI_2");

            entity.HasIndex(e => e.UzytkownicyId, "cennik_przesylek_klientow_FI_3");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CzyDarmowaDostawa)
                .HasColumnType("tinyint(4)")
                .HasColumnName("czy_darmowa_dostawa");
            entity.Property(e => e.CzyDomyslne)
                .HasColumnType("tinyint(4)")
                .HasColumnName("czy_domyslne");
            entity.Property(e => e.Kolejnosc)
                .HasColumnType("int(11)")
                .HasColumnName("kolejnosc");
            entity.Property(e => e.KrajeId)
                .HasColumnType("int(11)")
                .HasColumnName("kraje_id");
            entity.Property(e => e.KwotaBrutto)
                .HasMaxLength(20)
                .HasColumnName("kwota_brutto");
            entity.Property(e => e.KwotaZamowieniaDarmowejDostawy)
                .HasMaxLength(10)
                .HasColumnName("kwota_zamowienia_darmowej_dostawy");
            entity.Property(e => e.RodzajeDostawyId)
                .HasColumnType("int(11)")
                .HasColumnName("rodzaje_dostawy_id");
            entity.Property(e => e.UzytkownicyId)
                .HasColumnType("int(11)")
                .HasColumnName("uzytkownicy_id");
        });

        modelBuilder.Entity<Cenniki>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cenniki");

            entity.HasIndex(e => e.UuidPrzestrzeni, "cenniki_I_1");

            entity.HasIndex(e => e.UuidPrzestrzeni2, "cenniki_I_2");

            entity.HasIndex(e => e.UuidPrzestrzeni3, "cenniki_I_3");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AktywnaPrzestrzen)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("aktywna_przestrzen");
            entity.Property(e => e.AktywnaPrzestrzen2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("aktywna_przestrzen2");
            entity.Property(e => e.AktywnaPrzestrzen3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("aktywna_przestrzen3");
            entity.Property(e => e.Grupowanie).HasColumnName("grupowanie");
            entity.Property(e => e.Grupowanie2).HasColumnName("grupowanie2");
            entity.Property(e => e.Grupowanie3).HasColumnName("grupowanie3");
            entity.Property(e => e.Grupy).HasColumnName("grupy");
            entity.Property(e => e.GrupyUzytkownikow).HasColumnName("grupy_uzytkownikow");
            entity.Property(e => e.Konfiguracja).HasColumnName("konfiguracja");
            entity.Property(e => e.Konfiguracja2).HasColumnName("konfiguracja2");
            entity.Property(e => e.Konfiguracja3).HasColumnName("konfiguracja3");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(255)
                .HasColumnName("nazwa");
            entity.Property(e => e.NazwaPrzestrzeni)
                .HasMaxLength(255)
                .HasDefaultValueSql("'Zakres 1'")
                .HasColumnName("nazwa_przestrzeni");
            entity.Property(e => e.NazwaPrzestrzeni2)
                .HasMaxLength(255)
                .HasDefaultValueSql("'Zakres 2'")
                .HasColumnName("nazwa_przestrzeni2");
            entity.Property(e => e.NazwaPrzestrzeni3)
                .HasMaxLength(255)
                .HasDefaultValueSql("'Zakres 3'")
                .HasColumnName("nazwa_przestrzeni3");
            entity.Property(e => e.Przesylki).HasColumnName("przesylki");
            entity.Property(e => e.UuidPrzestrzeni)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("uuid_przestrzeni");
            entity.Property(e => e.UuidPrzestrzeni2)
                .HasDefaultValueSql("'2'")
                .HasColumnType("int(11)")
                .HasColumnName("uuid_przestrzeni2");
            entity.Property(e => e.UuidPrzestrzeni3)
                .HasDefaultValueSql("'3'")
                .HasColumnType("int(11)")
                .HasColumnName("uuid_przestrzeni3");
        });

        modelBuilder.Entity<CentraKosztowe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("centra_kosztowe");

            entity.HasIndex(e => e.IdUser, "centra_kosztowe_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.IdUser)
                .HasColumnType("int(11)")
                .HasColumnName("id_user");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(255)
                .HasColumnName("nazwa");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.CentraKosztowes)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("centra_kosztowe_FK_1");
        });

        modelBuilder.Entity<CentraNazwy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("centra_nazwy");

            entity.HasIndex(e => e.IdCentra, "centra_nazwy_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.IdCentra)
                .HasColumnType("int(11)")
                .HasColumnName("id_centra");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(255)
                .HasColumnName("nazwa");

            entity.HasOne(d => d.IdCentraNavigation).WithMany(p => p.CentraNazwies)
                .HasForeignKey(d => d.IdCentra)
                .HasConstraintName("centra_nazwy_FK_1");
        });

        modelBuilder.Entity<CentraWybrane>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("centra_wybrane");

            entity.HasIndex(e => e.IdUser, "centra_wybrane_FI_1");

            entity.HasIndex(e => e.IdCentrak, "centra_wybrane_FI_2");

            entity.HasIndex(e => e.IdCentran, "centra_wybrane_FI_3");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CzyDomyslne)
                .HasColumnType("tinyint(4)")
                .HasColumnName("czy_domyslne");
            entity.Property(e => e.IdCentrak)
                .HasColumnType("int(11)")
                .HasColumnName("id_centrak");
            entity.Property(e => e.IdCentran)
                .HasColumnType("int(11)")
                .HasColumnName("id_centran");
            entity.Property(e => e.IdUser)
                .HasColumnType("int(11)")
                .HasColumnName("id_user");

            entity.HasOne(d => d.IdCentrakNavigation).WithMany(p => p.CentraWybranes)
                .HasForeignKey(d => d.IdCentrak)
                .HasConstraintName("centra_wybrane_FK_2");

            entity.HasOne(d => d.IdCentranNavigation).WithMany(p => p.CentraWybranes)
                .HasForeignKey(d => d.IdCentran)
                .HasConstraintName("centra_wybrane_FK_3");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.CentraWybranes)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("centra_wybrane_FK_1");
        });

        modelBuilder.Entity<Czcionki>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("czcionki");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Domyslna)
                .HasColumnType("tinyint(4)")
                .HasColumnName("domyslna");
            entity.Property(e => e.EotBoldItalicPath)
                .HasMaxLength(150)
                .HasColumnName("eot_bold_italic_path");
            entity.Property(e => e.EotBoldPath)
                .HasMaxLength(150)
                .HasColumnName("eot_bold_path");
            entity.Property(e => e.EotItalicPath)
                .HasMaxLength(150)
                .HasColumnName("eot_italic_path");
            entity.Property(e => e.EotNormalPath)
                .HasMaxLength(150)
                .HasColumnName("eot_normal_path");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(50)
                .HasColumnName("nazwa");
            entity.Property(e => e.Openfont)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("openfont");
            entity.Property(e => e.OtfBoldItalicPath)
                .HasMaxLength(150)
                .HasColumnName("otf_bold_italic_path");
            entity.Property(e => e.OtfBoldPath)
                .HasMaxLength(150)
                .HasColumnName("otf_bold_path");
            entity.Property(e => e.OtfItalicPath)
                .HasMaxLength(150)
                .HasColumnName("otf_italic_path");
            entity.Property(e => e.OtfNormalPath)
                .HasMaxLength(150)
                .HasColumnName("otf_normal_path");
            entity.Property(e => e.TtfBoldItalicPath)
                .HasMaxLength(150)
                .HasColumnName("ttf_bold_italic_path");
            entity.Property(e => e.TtfBoldPath)
                .HasMaxLength(150)
                .HasColumnName("ttf_bold_path");
            entity.Property(e => e.TtfItalicPath)
                .HasMaxLength(150)
                .HasColumnName("ttf_italic_path");
            entity.Property(e => e.TtfNormalPath)
                .HasMaxLength(150)
                .HasColumnName("ttf_normal_path");
            entity.Property(e => e.WoffBoldItalicPath)
                .HasMaxLength(150)
                .HasColumnName("woff_bold_italic_path");
            entity.Property(e => e.WoffBoldPath)
                .HasMaxLength(150)
                .HasColumnName("woff_bold_path");
            entity.Property(e => e.WoffItalicPath)
                .HasMaxLength(150)
                .HasColumnName("woff_italic_path");
            entity.Property(e => e.WoffNormalPath)
                .HasMaxLength(150)
                .HasColumnName("woff_normal_path");
        });

        modelBuilder.Entity<Danetestowe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("danetestowe");

            entity.HasIndex(e => e.SzablonyproduktowId, "danetestowe_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Etykieta)
                .HasMaxLength(20)
                .HasColumnName("etykieta");
            entity.Property(e => e.SzablonyproduktowId)
                .HasColumnType("int(11)")
                .HasColumnName("szablonyproduktow_id");
            entity.Property(e => e.Text)
                .HasMaxLength(100)
                .HasColumnName("text");
            entity.Property(e => e.Typ)
                .HasColumnType("int(11)")
                .HasColumnName("typ");
        });

        modelBuilder.Entity<Email>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("emails");

            entity.HasIndex(e => e.RodzajemailiId, "emails_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Email1)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.RodzajemailiId)
                .HasColumnType("int(11)")
                .HasColumnName("rodzajemaili_id");
            entity.Property(e => e.Typ)
                .HasColumnType("int(11)")
                .HasColumnName("typ");
        });

        modelBuilder.Entity<Etykietyproduktyzapisane>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("etykietyproduktyzapisane");

            entity.HasIndex(e => e.KlientId, "etykietyproduktyzapisane_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.KlientId)
                .HasColumnType("int(11)")
                .HasColumnName("klient_id");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(50)
                .HasColumnName("nazwa");
        });

        modelBuilder.Entity<Faktura>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("faktura");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CzyKoszty)
                .HasColumnType("tinyint(4)")
                .HasColumnName("czy_koszty");
            entity.Property(e => e.CzyZaplacono)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("czy_zaplacono");
            entity.Property(e => e.DataOstatniejWysylki)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("data_ostatniej_wysylki");
            entity.Property(e => e.DataSprzedazy)
                .HasMaxLength(20)
                .HasColumnName("data_sprzedazy");
            entity.Property(e => e.DataUtworzenia)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("data_utworzenia");
            entity.Property(e => e.DataWystawienia)
                .HasMaxLength(20)
                .HasColumnName("data_wystawienia");
            entity.Property(e => e.DataWysylki)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("data_wysylki");
            entity.Property(e => e.DataZaplaty)
                .HasMaxLength(20)
                .HasColumnName("data_zaplaty");
            entity.Property(e => e.DataZatwierdzeniaPlatnosci)
                .HasMaxLength(20)
                .HasColumnName("data_zatwierdzenia_platnosci");
            entity.Property(e => e.DoZaplaty)
                .HasMaxLength(100)
                .HasColumnName("do_zaplaty");
            entity.Property(e => e.FormaPlatnosci)
                .HasMaxLength(50)
                .HasColumnName("forma_platnosci");
            entity.Property(e => e.KtoOstatnioWyslal)
                .HasMaxLength(20)
                .HasDefaultValueSql("'automat'")
                .HasColumnName("kto_ostatnio_wyslal");
            entity.Property(e => e.KtoUtworzyl)
                .HasMaxLength(20)
                .HasDefaultValueSql("'automat'")
                .HasColumnName("kto_utworzyl");
            entity.Property(e => e.KtoWyslal)
                .HasMaxLength(20)
                .HasDefaultValueSql("'automat'")
                .HasColumnName("kto_wyslal");
            entity.Property(e => e.KwotaBrutto)
                .HasMaxLength(100)
                .HasColumnName("kwota_brutto");
            entity.Property(e => e.KwotaBruttoSlownie)
                .HasMaxLength(300)
                .HasColumnName("kwota_brutto_slownie");
            entity.Property(e => e.KwotaNetto)
                .HasMaxLength(50)
                .HasColumnName("kwota_netto");
            entity.Property(e => e.KwotaVat)
                .HasMaxLength(50)
                .HasColumnName("kwota_vat");
            entity.Property(e => e.NAdres)
                .HasMaxLength(255)
                .HasColumnName("n_adres");
            entity.Property(e => e.NKodPocztowy)
                .HasMaxLength(12)
                .HasColumnName("n_kod_pocztowy");
            entity.Property(e => e.NMiejscowosc)
                .HasMaxLength(255)
                .HasColumnName("n_miejscowosc");
            entity.Property(e => e.NNazwaFirmyLubOsoby)
                .HasMaxLength(255)
                .HasColumnName("n_nazwa_firmy_lub_osoby");
            entity.Property(e => e.NNip)
                .HasMaxLength(20)
                .HasColumnName("n_nip");
            entity.Property(e => e.NumerFaktury)
                .HasMaxLength(100)
                .HasColumnName("numer_faktury");
            entity.Property(e => e.NumerRachunkuBankowego)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("numer_rachunku_bankowego");
            entity.Property(e => e.NumerReferencyjny)
                .HasMaxLength(400)
                .HasDefaultValueSql("''")
                .HasColumnName("numer_referencyjny");
            entity.Property(e => e.Opis)
                .HasMaxLength(100)
                .HasDefaultValueSql("' FAKTURA VAT'")
                .HasColumnName("opis");
            entity.Property(e => e.PrzesylkaKwotaBrutto)
                .HasMaxLength(50)
                .HasColumnName("przesylka_kwota_brutto");
            entity.Property(e => e.PrzesylkaKwotaNetto)
                .HasMaxLength(50)
                .HasColumnName("przesylka_kwota_netto");
            entity.Property(e => e.RodzajOpis)
                .HasMaxLength(100)
                .HasDefaultValueSql("'ORYGINAŁ/KOPIA'")
                .HasColumnName("rodzaj_opis");
            entity.Property(e => e.SAdres)
                .HasMaxLength(255)
                .HasColumnName("s_adres");
            entity.Property(e => e.SImieNazwisko)
                .HasMaxLength(120)
                .HasColumnName("s_imie_nazwisko");
            entity.Property(e => e.SKodPocztowy)
                .HasMaxLength(12)
                .HasColumnName("s_kod_pocztowy");
            entity.Property(e => e.SMiejscowosc)
                .HasMaxLength(255)
                .HasColumnName("s_miejscowosc");
            entity.Property(e => e.SNazwaFirmy)
                .HasMaxLength(255)
                .HasColumnName("s_nazwa_firmy");
            entity.Property(e => e.SNip)
                .HasMaxLength(20)
                .HasColumnName("s_nip");
            entity.Property(e => e.SprzedawcaId)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("sprzedawca_id");
            entity.Property(e => e.SwiftCode)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("swift_code");
            entity.Property(e => e.Uid)
                .HasMaxLength(255)
                .HasColumnName("uid");
            entity.Property(e => e.Uwagi)
                .HasColumnType("text")
                .HasColumnName("uwagi");
            entity.Property(e => e.Vat)
                .HasMaxLength(20)
                .HasColumnName("vat");
            entity.Property(e => e.Waluta)
                .HasMaxLength(3)
                .HasColumnName("waluta");
            entity.Property(e => e.Zaplacono)
                .HasMaxLength(100)
                .HasColumnName("zaplacono");
            entity.Property(e => e.ZatwierdzPlatnosc)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("zatwierdz_platnosc");
        });

        modelBuilder.Entity<FakturaZalacznik>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("faktura_zalacznik");

            entity.HasIndex(e => e.FakturaId, "faktura_zalacznik_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DataWystawienia)
                .HasMaxLength(20)
                .HasColumnName("data_wystawienia");
            entity.Property(e => e.FakturaId)
                .HasColumnType("int(11)")
                .HasColumnName("faktura_id");
            entity.Property(e => e.NAdres)
                .HasMaxLength(255)
                .HasColumnName("n_adres");
            entity.Property(e => e.NKodPocztowy)
                .HasMaxLength(12)
                .HasColumnName("n_kod_pocztowy");
            entity.Property(e => e.NMiejscowosc)
                .HasMaxLength(255)
                .HasColumnName("n_miejscowosc");
            entity.Property(e => e.NNazwaFirmyLubOsoby)
                .HasMaxLength(255)
                .HasColumnName("n_nazwa_firmy_lub_osoby");
            entity.Property(e => e.NNip)
                .HasMaxLength(13)
                .HasColumnName("n_nip");
            entity.Property(e => e.NumerFaktury)
                .HasMaxLength(100)
                .HasColumnName("numer_faktury");
            entity.Property(e => e.Opis)
                .HasMaxLength(100)
                .HasDefaultValueSql("'Załącznik do Faktury VAT'")
                .HasColumnName("opis");
            entity.Property(e => e.RodzajOpis)
                .HasMaxLength(100)
                .HasDefaultValueSql("'ORYGINAŁ/KOPIA'")
                .HasColumnName("rodzaj_opis");
            entity.Property(e => e.Uid)
                .HasMaxLength(255)
                .HasColumnName("uid");
            entity.Property(e => e.Uwagi)
                .HasColumnType("text")
                .HasColumnName("uwagi");

            entity.HasOne(d => d.Faktura).WithMany(p => p.FakturaZalaczniks)
                .HasForeignKey(d => d.FakturaId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("faktura_zalacznik_FK_1");
        });

        modelBuilder.Entity<Filtry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("filtry");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Grupa)
                .HasMaxLength(255)
                .HasColumnName("grupa");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(255)
                .HasColumnName("nazwa");
            entity.Property(e => e.Wartosc)
                .HasColumnType("text")
                .HasColumnName("wartosc");
        });

        modelBuilder.Entity<Formaty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("formaty");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(20)
                .HasColumnName("nazwa");
            entity.Property(e => e.WymiarminiaturyX)
                .HasColumnType("int(11)")
                .HasColumnName("wymiarminiatury_x");
            entity.Property(e => e.WymiarminiaturyY)
                .HasColumnType("int(11)")
                .HasColumnName("wymiarminiatury_y");
            entity.Property(e => e.WymiarmmX)
                .HasColumnType("int(11)")
                .HasColumnName("wymiarmm_x");
            entity.Property(e => e.WymiarmmY)
                .HasColumnType("int(11)")
                .HasColumnName("wymiarmm_y");
            entity.Property(e => e.WymiarpxX)
                .HasColumnType("int(11)")
                .HasColumnName("wymiarpx_x");
            entity.Property(e => e.WymiarpxY)
                .HasColumnType("int(11)")
                .HasColumnName("wymiarpx_y");
        });

        modelBuilder.Entity<Identyfikatory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("identyfikatory");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(255)
                .HasColumnName("nazwa");
            entity.Property(e => e.Typ)
                .HasColumnType("int(11)")
                .HasColumnName("typ");
            entity.Property(e => e.Wartosc)
                .HasMaxLength(255)
                .HasColumnName("wartosc");
        });

        modelBuilder.Entity<KampaniaMailingowa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("kampania_mailingowa");

            entity.HasIndex(e => e.CennikId, "kampania_mailingowa_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CennikId)
                .HasColumnType("int(11)")
                .HasColumnName("cennik_id");
            entity.Property(e => e.DataUruchomienia)
                .HasMaxLength(20)
                .HasColumnName("data_uruchomienia");
            entity.Property(e => e.DataUtworzenia)
                .HasMaxLength(20)
                .HasColumnName("data_utworzenia");
            entity.Property(e => e.DataZakonczenia)
                .HasMaxLength(20)
                .HasColumnName("data_zakonczenia");
            entity.Property(e => e.DomyslnyLayout)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("domyslny_layout");
            entity.Property(e => e.LandingpageCss)
                .HasColumnType("text")
                .HasColumnName("landingpage_css");
            entity.Property(e => e.LandingpageHtml)
                .HasColumnType("text")
                .HasColumnName("landingpage_html");
            entity.Property(e => e.NazwaKampanii)
                .HasMaxLength(100)
                .HasColumnName("nazwa_kampanii");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("status");
            entity.Property(e => e.Uid)
                .HasMaxLength(255)
                .HasColumnName("uid");
        });

        modelBuilder.Entity<KampaniaMailingowaStatystyka>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("kampania_mailingowa_statystyka");

            entity.HasIndex(e => e.KampaniaMailingowaId, "kampania_mailingowa_statystyka_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Data)
                .HasMaxLength(20)
                .HasColumnName("data");
            entity.Property(e => e.IloscWejsc)
                .HasColumnType("int(11)")
                .HasColumnName("ilosc_wejsc");
            entity.Property(e => e.KampaniaMailingowaId)
                .HasColumnType("int(11)")
                .HasColumnName("kampania_mailingowa_id");
        });

        modelBuilder.Entity<Kategorie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("kategorie");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Grafika)
                .HasMaxLength(150)
                .HasColumnName("grafika");
            entity.Property(e => e.IloscStron)
                .HasDefaultValueSql("'2'")
                .HasColumnType("int(11)")
                .HasColumnName("ilosc_stron");
            entity.Property(e => e.Margines)
                .HasDefaultValueSql("'10'")
                .HasColumnType("int(11)")
                .HasColumnName("margines");
            entity.Property(e => e.MarginesWewnetrzny)
                .HasDefaultValueSql("'5'")
                .HasColumnType("int(11)")
                .HasColumnName("margines_wewnetrzny");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(30)
                .HasColumnName("nazwa");
            entity.Property(e => e.Opis)
                .HasMaxLength(200)
                .HasColumnName("opis");
            entity.Property(e => e.Typproduktu)
                .HasColumnType("int(11)")
                .HasColumnName("typproduktu");
        });

        modelBuilder.Entity<Klienci>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("klienci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Femail)
                .HasMaxLength(60)
                .HasColumnName("femail");
            entity.Property(e => e.Fkodpocztowy)
                .HasMaxLength(12)
                .HasColumnName("fkodpocztowy");
            entity.Property(e => e.Fmiasto)
                .HasMaxLength(50)
                .HasColumnName("fmiasto");
            entity.Property(e => e.Fnazwafirmy)
                .HasMaxLength(255)
                .HasColumnName("fnazwafirmy");
            entity.Property(e => e.Fnip)
                .HasMaxLength(13)
                .HasColumnName("fnip");
            entity.Property(e => e.Fnrdomu)
                .HasMaxLength(4)
                .HasColumnName("fnrdomu");
            entity.Property(e => e.Fnrlokalu)
                .HasMaxLength(4)
                .HasColumnName("fnrlokalu");
            entity.Property(e => e.Ftel)
                .HasMaxLength(20)
                .HasColumnName("ftel");
            entity.Property(e => e.Ftelfax)
                .HasMaxLength(20)
                .HasColumnName("ftelfax");
            entity.Property(e => e.Fulica)
                .HasMaxLength(255)
                .HasColumnName("fulica");
            entity.Property(e => e.Fwww)
                .HasMaxLength(255)
                .HasColumnName("fwww");
            entity.Property(e => e.Haslo)
                .HasMaxLength(20)
                .HasColumnName("haslo");
            entity.Property(e => e.Kemail)
                .HasMaxLength(60)
                .HasColumnName("kemail");
            entity.Property(e => e.Kfax)
                .HasMaxLength(20)
                .HasColumnName("kfax");
            entity.Property(e => e.Kimie)
                .HasMaxLength(30)
                .HasColumnName("kimie");
            entity.Property(e => e.Knazwisko)
                .HasMaxLength(50)
                .HasColumnName("knazwisko");
            entity.Property(e => e.Ktel)
                .HasMaxLength(20)
                .HasColumnName("ktel");
            entity.Property(e => e.Kwww)
                .HasMaxLength(255)
                .HasColumnName("kwww");
            entity.Property(e => e.Login)
                .HasMaxLength(60)
                .HasColumnName("login");
            entity.Property(e => e.Skrot)
                .HasMaxLength(255)
                .HasColumnName("skrot");
            entity.Property(e => e.Wemail)
                .HasMaxLength(60)
                .HasColumnName("wemail");
            entity.Property(e => e.Wkodpocztowy)
                .HasMaxLength(12)
                .HasColumnName("wkodpocztowy");
            entity.Property(e => e.Wmiasto)
                .HasMaxLength(50)
                .HasColumnName("wmiasto");
            entity.Property(e => e.Wnazwafirmy)
                .HasMaxLength(255)
                .HasColumnName("wnazwafirmy");
            entity.Property(e => e.Wnip)
                .HasMaxLength(13)
                .HasColumnName("wnip");
            entity.Property(e => e.Wnrdomu)
                .HasMaxLength(4)
                .HasColumnName("wnrdomu");
            entity.Property(e => e.Wnrlokalu)
                .HasMaxLength(4)
                .HasColumnName("wnrlokalu");
            entity.Property(e => e.Wtel)
                .HasMaxLength(20)
                .HasColumnName("wtel");
            entity.Property(e => e.Wtelfax)
                .HasMaxLength(20)
                .HasColumnName("wtelfax");
            entity.Property(e => e.Wulica)
                .HasMaxLength(255)
                .HasColumnName("wulica");
            entity.Property(e => e.Wwww)
                .HasMaxLength(255)
                .HasColumnName("wwww");
        });

        modelBuilder.Entity<Klientcennik>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("klientcennik");

            entity.HasIndex(e => e.UzytkownicyId, "klientcennik_FI_1");

            entity.HasIndex(e => e.CennikId, "klientcennik_FI_2");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CennikId)
                .HasColumnType("int(11)")
                .HasColumnName("cennik_id");
            entity.Property(e => e.UzytkownicyId)
                .HasColumnType("int(11)")
                .HasColumnName("uzytkownicy_id");
        });

        modelBuilder.Entity<KodyProgramPartnerski>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("kody_program_partnerski");

            entity.HasIndex(e => e.ParentUserId, "kody_program_partnerski_FI_1");

            entity.HasIndex(e => e.UserId, "kody_program_partnerski_FI_2");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Aktywny)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("aktywny");
            entity.Property(e => e.DataUtworzenia)
                .HasMaxLength(20)
                .HasColumnName("data_utworzenia");
            entity.Property(e => e.DataWykorzystania)
                .HasMaxLength(20)
                .HasColumnName("data_wykorzystania");
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .HasColumnName("kod");
            entity.Property(e => e.ParentUserId)
                .HasColumnType("int(11)")
                .HasColumnName("parent_user_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<Komentarzeproduktyzamowienie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("komentarzeproduktyzamowienie");

            entity.HasIndex(e => e.ProduktyzamowienieId, "komentarzeproduktyzamowienie_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Data)
                .HasMaxLength(20)
                .HasColumnName("data");
            entity.Property(e => e.Opis)
                .HasMaxLength(1000)
                .HasColumnName("opis");
            entity.Property(e => e.ProduktyzamowienieId)
                .HasColumnType("int(11)")
                .HasColumnName("produktyzamowienie_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("status");
        });

        modelBuilder.Entity<KonfiguracjaUzytkownika>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("konfiguracja_uzytkownika");

            entity.HasIndex(e => e.UzytkownicyId, "konfiguracja_uzytkownika_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Konfiguracja)
                .HasColumnType("mediumtext")
                .HasColumnName("konfiguracja");
            entity.Property(e => e.UzytkownicyId)
                .HasColumnType("int(11)")
                .HasColumnName("uzytkownicy_id");
        });

        modelBuilder.Entity<Konfiguracjaczcionek>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("konfiguracjaczcionek");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Konfiguracja)
                .HasColumnType("text")
                .HasColumnName("konfiguracja");
        });

        modelBuilder.Entity<Konkursy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("konkursy");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Aktywny)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("aktywny");
            entity.Property(e => e.DataDo)
                .HasMaxLength(20)
                .HasColumnName("data_do");
            entity.Property(e => e.DataOd)
                .HasMaxLength(20)
                .HasColumnName("data_od");
            entity.Property(e => e.NazwaKonkursu)
                .HasMaxLength(255)
                .HasColumnName("nazwa_konkursu");
        });

        modelBuilder.Entity<KontaBankoweKonfiguracja>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("konta_bankowe_konfiguracja");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CzyDomyslne)
                .HasColumnType("tinyint(4)")
                .HasColumnName("czy_domyslne");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(100)
                .HasColumnName("nazwa");
            entity.Property(e => e.NumerKonta)
                .HasMaxLength(35)
                .HasColumnName("numer_konta");
            entity.Property(e => e.SprzedawcaId)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("sprzedawca_id");
            entity.Property(e => e.SwiftCode)
                .HasMaxLength(10)
                .HasColumnName("swift_code");
            entity.Property(e => e.Visible)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<Kontrahenci>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("kontrahenci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Adres)
                .HasMaxLength(255)
                .HasColumnName("adres");
            entity.Property(e => e.Domyslny)
                .HasColumnType("tinyint(4)")
                .HasColumnName("domyslny");
            entity.Property(e => e.KodPocztowy)
                .HasMaxLength(12)
                .HasColumnName("kod_pocztowy");
            entity.Property(e => e.Miejscowosc)
                .HasMaxLength(255)
                .HasColumnName("miejscowosc");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(255)
                .HasColumnName("nazwa");
            entity.Property(e => e.NazwaKontrahenta)
                .HasMaxLength(255)
                .HasColumnName("nazwa_kontrahenta");
            entity.Property(e => e.Nip)
                .HasMaxLength(20)
                .HasColumnName("nip");
            entity.Property(e => e.RootUserId)
                .HasColumnType("int(11)")
                .HasColumnName("root_user_id");
        });

        modelBuilder.Entity<KontrahenciWybrani>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("kontrahenci_wybrani");

            entity.HasIndex(e => e.KontrahentId, "kontrahenci_wybrani_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Domyslny)
                .HasColumnType("tinyint(4)")
                .HasColumnName("domyslny");
            entity.Property(e => e.KontrahentId)
                .HasColumnType("int(11)")
                .HasColumnName("kontrahent_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");

            entity.HasOne(d => d.Kontrahent).WithMany(p => p.KontrahenciWybranis)
                .HasForeignKey(d => d.KontrahentId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("kontrahenci_wybrani_FK_1");
        });

        modelBuilder.Entity<Koszyk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("koszyk");

            entity.HasIndex(e => e.UzytkownicyId, "koszyk_FI_1");

            entity.HasIndex(e => e.UuidPrzestrzeni, "koszyk_I_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DataOstatniejAktywnosci)
                .HasMaxLength(20)
                .HasColumnName("data_ostatniej_aktywnosci");
            entity.Property(e => e.DataStatusu)
                .HasMaxLength(20)
                .HasColumnName("data_statusu");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("status");
            entity.Property(e => e.Uid)
                .HasMaxLength(255)
                .HasColumnName("uid");
            entity.Property(e => e.UuidPrzestrzeni)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("uuid_przestrzeni");
            entity.Property(e => e.UzytkownicyId)
                .HasColumnType("int(11)")
                .HasColumnName("uzytkownicy_id");
        });

        modelBuilder.Entity<Kraje>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("kraje");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .HasColumnName("kod");
            entity.Property(e => e.Kolejnosc)
                .HasColumnType("int(11)")
                .HasColumnName("kolejnosc");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("nazwa");
            entity.Property(e => e.NazwaDe)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("nazwa_de");
            entity.Property(e => e.NazwaEn)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("nazwa_en");
        });

        modelBuilder.Entity<Kryteriasortowanium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("kryteriasortowania");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Konfiguracja)
                .HasColumnType("text")
                .HasColumnName("konfiguracja");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(100)
                .HasColumnName("nazwa");
            entity.Property(e => e.Order)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("order");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("type");
        });

        modelBuilder.Entity<Kuponyrabatowe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("kuponyrabatowe");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DataUtworzenia)
                .HasMaxLength(20)
                .HasColumnName("data_utworzenia");
            entity.Property(e => e.DataWaznosci)
                .HasMaxLength(20)
                .HasColumnName("data_waznosci");
            entity.Property(e => e.Kodkuponu)
                .HasMaxLength(100)
                .HasColumnName("kodkuponu");
            entity.Property(e => e.Krotnoscuzycia)
                .HasMaxLength(10)
                .HasColumnName("krotnoscuzycia");
            entity.Property(e => e.Krotnoscwykorzystania)
                .HasMaxLength(10)
                .HasDefaultValueSql("'0'")
                .HasColumnName("krotnoscwykorzystania");
            entity.Property(e => e.Kwota)
                .HasMaxLength(10)
                .HasColumnName("kwota");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'2'")
                .HasColumnType("int(11)")
                .HasColumnName("status");
            entity.Property(e => e.Typ)
                .HasDefaultValueSql("'2'")
                .HasColumnType("int(11)")
                .HasColumnName("typ");
            entity.Property(e => e.Typkuponu)
                .HasColumnType("int(11)")
                .HasColumnName("typkuponu");
            entity.Property(e => e.UzytkownicyId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("uzytkownicy_id");
            entity.Property(e => e.Wartosc1)
                .HasMaxLength(10)
                .HasColumnName("wartosc1");
            entity.Property(e => e.Wartosc2)
                .HasMaxLength(10)
                .HasColumnName("wartosc2");
        });

        modelBuilder.Entity<Kuponyrabatowerezerwacja>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("kuponyrabatowerezerwacja");

            entity.HasIndex(e => e.KuponyrabatoweId, "kuponyrabatowerezerwacja_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DataRezerwacji)
                .HasMaxLength(20)
                .HasColumnName("data_rezerwacji");
            entity.Property(e => e.KuponyrabatoweId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("kuponyrabatowe_id");
        });

        modelBuilder.Entity<Logasadmin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("logasadmin");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Uid)
                .HasColumnType("text")
                .HasColumnName("uid");
        });

        modelBuilder.Entity<Newsletteruzytkownicy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("newsletteruzytkownicy");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("active");
            entity.Property(e => e.DataAktywacji)
                .HasMaxLength(20)
                .HasColumnName("data_aktywacji");
            entity.Property(e => e.DataRejestracji)
                .HasMaxLength(20)
                .HasColumnName("data_rejestracji");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .HasColumnName("email");
            entity.Property(e => e.Sumakontrolna)
                .HasMaxLength(255)
                .HasColumnName("sumakontrolna");
        });

        modelBuilder.Entity<Opinie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("opinie");

            entity.HasIndex(e => e.UzytkownicyId, "opinie_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AktywnaNaFacebook)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("aktywna_na_facebook");
            entity.Property(e => e.AktywnaNaStronie)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("aktywna_na_stronie");
            entity.Property(e => e.DataUtworzenia)
                .HasMaxLength(20)
                .HasColumnName("data_utworzenia");
            entity.Property(e => e.DataZatwierdzenia)
                .HasMaxLength(20)
                .HasColumnName("data_zatwierdzenia");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.FacebookPageId)
                .HasMaxLength(100)
                .HasColumnName("facebook_page_id");
            entity.Property(e => e.FacebookPostId)
                .HasMaxLength(100)
                .HasColumnName("facebook_post_id");
            entity.Property(e => e.ImieNazwisko)
                .HasMaxLength(100)
                .HasColumnName("imie_nazwisko");
            entity.Property(e => e.Login)
                .HasMaxLength(60)
                .HasColumnName("login");
            entity.Property(e => e.Opinia)
                .HasColumnType("text")
                .HasColumnName("opinia");
            entity.Property(e => e.Pytanie1)
                .HasMaxLength(6)
                .HasColumnName("pytanie_1");
            entity.Property(e => e.Pytanie2)
                .HasMaxLength(6)
                .HasColumnName("pytanie_2");
            entity.Property(e => e.Pytanie3)
                .HasMaxLength(6)
                .HasColumnName("pytanie_3");
            entity.Property(e => e.Uwagi)
                .HasColumnType("text")
                .HasColumnName("uwagi");
            entity.Property(e => e.UzytkownicyId)
                .HasColumnType("int(11)")
                .HasColumnName("uzytkownicy_id");
        });

        modelBuilder.Entity<Paczkomaty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("paczkomaty");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.KodPocztowy)
                .HasMaxLength(12)
                .HasColumnName("kod_pocztowy");
            entity.Property(e => e.Miejscowosc)
                .HasMaxLength(100)
                .HasColumnName("miejscowosc");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(100)
                .HasColumnName("nazwa");
            entity.Property(e => e.NumerBudynku)
                .HasMaxLength(10)
                .HasColumnName("numer_budynku");
            entity.Property(e => e.Status)
                .HasColumnType("tinyint(4)")
                .HasColumnName("status");
            entity.Property(e => e.Ulica)
                .HasMaxLength(100)
                .HasColumnName("ulica");
        });

        modelBuilder.Entity<PaczkomatyKonfiguracja>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("paczkomaty_konfiguracja");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DataAktualizacji)
                .HasMaxLength(20)
                .HasColumnName("data_aktualizacji");
            entity.Property(e => e.DataUtworzenia)
                .HasMaxLength(20)
                .HasColumnName("data_utworzenia");
            entity.Property(e => e.Konfiguracja).HasColumnName("konfiguracja");
            entity.Property(e => e.KonfiguracjaTymczasowa).HasColumnName("konfiguracja_tymczasowa");
        });

        modelBuilder.Entity<Papier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("papier");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.BigIkonaPath)
                .HasMaxLength(200)
                .HasColumnName("big_ikona_path");
            entity.Property(e => e.CzasRealizacji)
                .HasMaxLength(100)
                .HasColumnName("czas_realizacji");
            entity.Property(e => e.IkonaPath)
                .HasMaxLength(200)
                .HasColumnName("ikona_path");
            entity.Property(e => e.Liczbastron)
                .HasMaxLength(20)
                .HasColumnName("liczbastron");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(30)
                .HasColumnName("nazwa");
            entity.Property(e => e.Numer)
                .HasColumnType("int(11)")
                .HasColumnName("numer");
            entity.Property(e => e.Opis)
                .HasMaxLength(200)
                .HasColumnName("opis");
            entity.Property(e => e.RozszerzonyOpis)
                .HasColumnType("text")
                .HasColumnName("rozszerzony_opis");
        });

        modelBuilder.Entity<ParametryProduktow>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("parametry_produktow");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(255)
                .HasColumnName("nazwa");
            entity.Property(e => e.Pokaz)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("pokaz");
            entity.Property(e => e.Typ)
                .HasMaxLength(3)
                .HasColumnName("typ");
        });

        modelBuilder.Entity<Podkategorie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("podkategorie");

            entity.HasIndex(e => e.KategorieId, "podkategorie_FI_1");

            entity.HasIndex(e => e.FormatyId, "podkategorie_FI_2");

            entity.HasIndex(e => e.PodkategoriaGlownaId, "podkategorie_FI_3");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.FormatyId)
                .HasColumnType("int(11)")
                .HasColumnName("formaty_id");
            entity.Property(e => e.KategorieId)
                .HasColumnType("int(11)")
                .HasColumnName("kategorie_id");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(30)
                .HasColumnName("nazwa");
            entity.Property(e => e.Opis)
                .HasMaxLength(200)
                .HasColumnName("opis");
            entity.Property(e => e.PodkategoriaGlownaId)
                .HasColumnType("int(11)")
                .HasColumnName("podkategoria_glowna_id");
            entity.Property(e => e.Visible)
                .HasColumnType("tinyint(4)")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<Podkategorieseo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("podkategorieseo");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.Header)
                .HasMaxLength(200)
                .HasColumnName("header");
            entity.Property(e => e.HeaderDesc)
                .HasColumnType("text")
                .HasColumnName("header_desc");
            entity.Property(e => e.Keywords)
                .HasMaxLength(200)
                .HasColumnName("keywords");
            entity.Property(e => e.PodkategorieId)
                .HasColumnType("int(11)")
                .HasColumnName("podkategorie_id");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Probkidrukow>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("probkidrukow");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Daneadresowe)
                .HasMaxLength(255)
                .HasColumnName("daneadresowe");
            entity.Property(e => e.DataZgloszenia)
                .HasMaxLength(20)
                .HasColumnName("data_zgloszenia");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
        });

        modelBuilder.Entity<Produkty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("produkty");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DataAktualizacji)
                .HasMaxLength(20)
                .HasColumnName("data_aktualizacji");
            entity.Property(e => e.DataUtworzenia)
                .HasMaxLength(20)
                .HasColumnName("data_utworzenia");
            entity.Property(e => e.IkonaSciezka)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("ikona_sciezka");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(255)
                .HasColumnName("nazwa");
            entity.Property(e => e.Szablon)
                .HasColumnType("text")
                .HasColumnName("szablon");
        });

        modelBuilder.Entity<Produkty7dniowe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("produkty7dniowe");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DataWaznosci)
                .HasMaxLength(20)
                .HasColumnName("data_waznosci");
            entity.Property(e => e.DataZapis)
                .HasMaxLength(20)
                .HasColumnName("data_zapis");
            entity.Property(e => e.DostepnaMiniatura)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("dostepna_miniatura");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .HasColumnName("email");
            entity.Property(e => e.Konfiguracja)
                .HasColumnType("text")
                .HasColumnName("konfiguracja");
            entity.Property(e => e.Opis)
                .HasColumnType("text")
                .HasColumnName("opis");
            entity.Property(e => e.Salt)
                .HasMaxLength(255)
                .HasColumnName("salt");
            entity.Property(e => e.Tytul)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("tytul");
        });

        modelBuilder.Entity<ProduktyKlientow>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("produkty_klientow");

            entity.HasIndex(e => e.KlientId, "produkty_klientow_FI_1");

            entity.HasIndex(e => e.RodzajProduktu, "produkty_klientow_FI_2");

            entity.HasIndex(e => e.IdWartosc, "produkty_klientow_FI_3");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AktywujDodanieDoKoszyka)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("aktywuj_dodanie_do_koszyka");
            entity.Property(e => e.AktywujPobieraniePlikow)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("aktywuj_pobieranie_plikow");
            entity.Property(e => e.AktywujWgrywaniePlikow)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("aktywuj_wgrywanie_plikow");
            entity.Property(e => e.CzyPubliczny)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("czy_publiczny");
            entity.Property(e => e.DataAktualizacji)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("data_aktualizacji");
            entity.Property(e => e.DataUtworzenia)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("data_utworzenia");
            entity.Property(e => e.IdWartosc)
                .HasColumnType("int(11)")
                .HasColumnName("id_wartosc");
            entity.Property(e => e.KlientId)
                .HasColumnType("int(11)")
                .HasColumnName("klient_id");
            entity.Property(e => e.KonfiguracjaSvg).HasColumnName("konfiguracja_svg");
            entity.Property(e => e.KtoAktualizowal)
                .HasMaxLength(20)
                .HasDefaultValueSql("'automat'")
                .HasColumnName("kto_aktualizowal");
            entity.Property(e => e.KtoUtworzyl)
                .HasMaxLength(20)
                .HasDefaultValueSql("'automat'")
                .HasColumnName("kto_utworzyl");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(255)
                .HasColumnName("nazwa");
            entity.Property(e => e.PlikPobieraniePath)
                .HasMaxLength(200)
                .HasColumnName("plik_pobieranie_path");
            entity.Property(e => e.RodzajProduktu)
                .HasColumnType("int(11)")
                .HasColumnName("rodzaj_produktu");
            entity.Property(e => e.Szerokosc)
                .HasColumnType("int(11)")
                .HasColumnName("szerokosc");
            entity.Property(e => e.Szerokosc2)
                .HasMaxLength(255)
                .HasColumnName("szerokosc2");
            entity.Property(e => e.Tlo)
                .HasColumnType("text")
                .HasColumnName("tlo");
            entity.Property(e => e.Wysokosc)
                .HasColumnType("int(11)")
                .HasColumnName("wysokosc");
            entity.Property(e => e.Wysokosc2)
                .HasMaxLength(255)
                .HasColumnName("wysokosc2");

            entity.HasOne(d => d.Klient).WithMany(p => p.ProduktyKlientows)
                .HasForeignKey(d => d.KlientId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("produkty_klientow_FK_1");

            entity.HasOne(d => d.RodzajProduktuNavigation).WithMany(p => p.ProduktyKlientows)
                .HasForeignKey(d => d.RodzajProduktu)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("produkty_klientow_FK_2");
        });

        modelBuilder.Entity<ProduktyParametry>(entity =>
        {
            entity.HasKey(e => new { e.IdProdukt, e.IdParametr }).HasName("PRIMARY");

            entity.ToTable("produkty_parametry");

            entity.Property(e => e.IdProdukt)
                .HasColumnType("int(11)")
                .HasColumnName("id_produkt");
            entity.Property(e => e.IdParametr)
                .HasColumnType("int(11)")
                .HasColumnName("id_parametr");
        });

        modelBuilder.Entity<ProduktyWartosci>(entity =>
        {
            entity.HasKey(e => new { e.IdProdukt, e.IdWartosc }).HasName("PRIMARY");

            entity.ToTable("produkty_wartosci");

            entity.Property(e => e.IdProdukt)
                .HasColumnType("int(11)")
                .HasColumnName("id_produkt");
            entity.Property(e => e.IdWartosc)
                .HasColumnType("int(11)")
                .HasColumnName("id_wartosc");
        });

        modelBuilder.Entity<Produktyfaktura>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("produktyfaktura");

            entity.HasIndex(e => e.FakturaId, "produktyfaktura_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.FakturaId)
                .HasColumnType("int(11)")
                .HasColumnName("faktura_id");
            entity.Property(e => e.Ilosc)
                .HasMaxLength(100)
                .HasColumnName("ilosc");
            entity.Property(e => e.Jednostka)
                .HasMaxLength(20)
                .HasColumnName("jednostka");
            entity.Property(e => e.Konfiguracja).HasColumnName("konfiguracja");
            entity.Property(e => e.Koszty)
                .HasColumnType("text")
                .HasColumnName("koszty");
            entity.Property(e => e.KwotaBruttoPoRabacie)
                .HasMaxLength(20)
                .HasColumnName("kwota_brutto_po_rabacie");
            entity.Property(e => e.KwotaBruttoPrzedRabatem)
                .HasMaxLength(20)
                .HasColumnName("kwota_brutto_przed_rabatem");
            entity.Property(e => e.KwotaNettoPoRabacie)
                .HasMaxLength(20)
                .HasColumnName("kwota_netto_po_rabacie");
            entity.Property(e => e.KwotaNettoPrzedRabatem)
                .HasMaxLength(20)
                .HasColumnName("kwota_netto_przed_rabatem");
            entity.Property(e => e.LiczBrutto)
                .HasColumnType("int(1)")
                .HasColumnName("licz_brutto");
            entity.Property(e => e.Naklad)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("naklad");
            entity.Property(e => e.NazwaKlienta)
                .HasColumnType("text")
                .HasColumnName("nazwa_klienta");
            entity.Property(e => e.Opis)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("opis");
            entity.Property(e => e.Rabat)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("rabat");
            entity.Property(e => e.Vat)
                .HasMaxLength(20)
                .HasColumnName("vat");

            entity.HasOne(d => d.Faktura).WithMany(p => p.Produktyfakturas)
                .HasForeignKey(d => d.FakturaId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("produktyfaktura_FK_1");
        });

        modelBuilder.Entity<Produktyfirmowe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("produktyfirmowe");

            entity.HasIndex(e => e.UzytkownicyId, "produktyfirmowe_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Konfiguracja)
                .HasColumnType("text")
                .HasColumnName("konfiguracja");
            entity.Property(e => e.Salt)
                .HasMaxLength(255)
                .HasColumnName("salt");
            entity.Property(e => e.UzytkownicyId)
                .HasColumnType("int(11)")
                .HasColumnName("uzytkownicy_id");
        });

        modelBuilder.Entity<Produktykoszyk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("produktykoszyk");

            entity.HasIndex(e => e.KoszykId, "produktykoszyk_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.BruttoPoRabacie)
                .HasMaxLength(20)
                .HasColumnName("brutto_po_rabacie");
            entity.Property(e => e.BruttoPrzedRabatem)
                .HasMaxLength(20)
                .HasColumnName("brutto_przed_rabatem");
            entity.Property(e => e.CzasRealizacji)
                .HasColumnType("int(11)")
                .HasColumnName("czas_realizacji");
            entity.Property(e => e.CzasRealizacjiKoniec)
                .HasColumnType("int(11)")
                .HasColumnName("czas_realizacji_koniec");
            entity.Property(e => e.CzasRealizacjiStart)
                .HasColumnType("int(11)")
                .HasColumnName("czas_realizacji_start");
            entity.Property(e => e.CzasZrealizowano)
                .HasColumnType("int(11)")
                .HasColumnName("czas_zrealizowano");
            entity.Property(e => e.Ilosc)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("ilosc");
            entity.Property(e => e.Jednostka)
                .HasMaxLength(255)
                .HasColumnName("jednostka");
            entity.Property(e => e.Kolejnosc)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("kolejnosc");
            entity.Property(e => e.Konfiguracja).HasColumnName("konfiguracja");
            entity.Property(e => e.Koszty)
                .HasColumnType("text")
                .HasColumnName("koszty");
            entity.Property(e => e.KoszykId)
                .HasColumnType("int(11)")
                .HasColumnName("koszyk_id");
            entity.Property(e => e.LiczBrutto)
                .HasColumnType("int(11)")
                .HasColumnName("licz_brutto");
            entity.Property(e => e.NazwaKlienta)
                .HasColumnType("text")
                .HasColumnName("nazwa_klienta");
            entity.Property(e => e.NettoPoRabacie)
                .HasMaxLength(20)
                .HasColumnName("netto_po_rabacie");
            entity.Property(e => e.NettoPrzedRabatem)
                .HasMaxLength(20)
                .HasColumnName("netto_przed_rabatem");
            entity.Property(e => e.Opis)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("opis");
            entity.Property(e => e.Rabat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'")
                .HasColumnName("rabat");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("status");
            entity.Property(e => e.Typproduktu)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("typproduktu");
            entity.Property(e => e.Uid)
                .HasMaxLength(255)
                .HasColumnName("uid");
            entity.Property(e => e.UzytkownicyId)
                .HasColumnType("int(11)")
                .HasColumnName("uzytkownicy_id");
            entity.Property(e => e.Vat)
                .HasMaxLength(20)
                .HasColumnName("vat");
        });

        modelBuilder.Entity<Produktyzamowienie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("produktyzamowienie");

            entity.HasIndex(e => e.ZamowienieId, "produktyzamowienie_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.BruttoPoRabacie)
                .HasMaxLength(20)
                .HasColumnName("brutto_po_rabacie");
            entity.Property(e => e.BruttoPrzedRabatem)
                .HasMaxLength(20)
                .HasColumnName("brutto_przed_rabatem");
            entity.Property(e => e.CzasRealizacji)
                .HasDefaultValueSql("'3'")
                .HasColumnType("int(11)")
                .HasColumnName("czas_realizacji");
            entity.Property(e => e.CzasRealizacjiKoniec)
                .HasColumnType("int(11)")
                .HasColumnName("czas_realizacji_koniec");
            entity.Property(e => e.CzasRealizacjiStart)
                .HasColumnType("int(11)")
                .HasColumnName("czas_realizacji_start");
            entity.Property(e => e.CzasZrealizowano)
                .HasColumnType("int(11)")
                .HasColumnName("czas_zrealizowano");
            entity.Property(e => e.Ilosc)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("ilosc");
            entity.Property(e => e.Jednostka)
                .HasMaxLength(255)
                .HasColumnName("jednostka");
            entity.Property(e => e.Konfiguracja).HasColumnName("konfiguracja");
            entity.Property(e => e.Koszty)
                .HasColumnType("text")
                .HasColumnName("koszty");
            entity.Property(e => e.LiczBrutto)
                .HasColumnType("int(11)")
                .HasColumnName("licz_brutto");
            entity.Property(e => e.NazwaKlienta)
                .HasColumnType("text")
                .HasColumnName("nazwa_klienta");
            entity.Property(e => e.NettoPoRabacie)
                .HasMaxLength(20)
                .HasColumnName("netto_po_rabacie");
            entity.Property(e => e.NettoPrzedRabatem)
                .HasMaxLength(20)
                .HasColumnName("netto_przed_rabatem");
            entity.Property(e => e.Opis)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("opis");
            entity.Property(e => e.Rabat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'")
                .HasColumnName("rabat");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("status");
            entity.Property(e => e.Typproduktu)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("typproduktu");
            entity.Property(e => e.Uid)
                .HasMaxLength(255)
                .HasColumnName("uid");
            entity.Property(e => e.Vat)
                .HasMaxLength(20)
                .HasColumnName("vat");
            entity.Property(e => e.ZamowienieId)
                .HasColumnType("int(11)")
                .HasColumnName("zamowienie_id");

            entity.HasOne(d => d.Zamowienie).WithMany(p => p.Produktyzamowienies)
                .HasForeignKey(d => d.ZamowienieId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("produktyzamowienie_FK_1");
        });

        modelBuilder.Entity<Produktyzapisane>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("produktyzapisane");

            entity.HasIndex(e => e.KlientId, "produktyzapisane_FI_1");

            entity.HasIndex(e => e.RodzajProduktu, "produktyzapisane_FI_2");

            entity.HasIndex(e => e.IdWartosc, "produktyzapisane_FI_3");

            entity.HasIndex(e => e.UuidPrzestrzeni, "produktyzapisane_I_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AktywujDodanieDoKoszyka)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("aktywuj_dodanie_do_koszyka");
            entity.Property(e => e.AktywujWgrywaniePlikow)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("aktywuj_wgrywanie_plikow");
            entity.Property(e => e.DataAkceptacji)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("data_akceptacji");
            entity.Property(e => e.DataOstatniejModyfikacji)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("data_ostatniej_modyfikacji");
            entity.Property(e => e.DataUtworzenia)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("data_utworzenia");
            entity.Property(e => e.EmailAkceptacji)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("email_akceptacji");
            entity.Property(e => e.Etykiety)
                .HasMaxLength(255)
                .HasColumnName("etykiety");
            entity.Property(e => e.IdWartosc)
                .HasColumnType("int(11)")
                .HasColumnName("id_wartosc");
            entity.Property(e => e.KlientId)
                .HasColumnType("int(11)")
                .HasColumnName("klient_id");
            entity.Property(e => e.KonfiguracjaSvg).HasColumnName("konfiguracja_svg");
            entity.Property(e => e.KtoOstatnioModyfikowal)
                .HasMaxLength(20)
                .HasDefaultValueSql("'automat'")
                .HasColumnName("kto_ostatnio_modyfikowal");
            entity.Property(e => e.KtoUtworzyl)
                .HasMaxLength(20)
                .HasDefaultValueSql("'automat'")
                .HasColumnName("kto_utworzyl");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(255)
                .HasColumnName("nazwa");
            entity.Property(e => e.RodzajProduktu)
                .HasColumnType("int(11)")
                .HasColumnName("rodzaj_produktu");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("status");
            entity.Property(e => e.Szerokosc)
                .HasColumnType("int(11)")
                .HasColumnName("szerokosc");
            entity.Property(e => e.Szerokosc2)
                .HasMaxLength(255)
                .HasColumnName("szerokosc2");
            entity.Property(e => e.Tlo)
                .HasColumnType("text")
                .HasColumnName("tlo");
            entity.Property(e => e.UuidPrzestrzeni)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("uuid_przestrzeni");
            entity.Property(e => e.Wysokosc)
                .HasColumnType("int(11)")
                .HasColumnName("wysokosc");
            entity.Property(e => e.Wysokosc2)
                .HasMaxLength(255)
                .HasColumnName("wysokosc2");

            entity.HasOne(d => d.Klient).WithMany(p => p.Produktyzapisanes)
                .HasForeignKey(d => d.KlientId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("produktyzapisane_FK_1");

            entity.HasOne(d => d.RodzajProduktuNavigation).WithMany(p => p.Produktyzapisanes)
                .HasForeignKey(d => d.RodzajProduktu)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("produktyzapisane_FK_2");
        });

        modelBuilder.Entity<Produktyzapisaneakceptacja>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("produktyzapisaneakceptacja");

            entity.HasIndex(e => e.ProduktyzapisaneId, "produktyzapisaneakceptacja_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DataOdpowiedzi)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("data_odpowiedzi");
            entity.Property(e => e.DataProsbyOAkceptacje)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("data_prosby_o_akceptacje");
            entity.Property(e => e.DataWaznosci)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("data_waznosci");
            entity.Property(e => e.EmailProsbyOAkceptacje)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("email_prosby_o_akceptacje");
            entity.Property(e => e.ProduktyzapisaneId)
                .HasColumnType("int(11)")
                .HasColumnName("produktyzapisane_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("status");
            entity.Property(e => e.TrescOdpowiedzi)
                .HasColumnType("text")
                .HasColumnName("tresc_odpowiedzi");
            entity.Property(e => e.TrescProsby)
                .HasColumnType("text")
                .HasColumnName("tresc_prosby");
            entity.Property(e => e.TytulEmaila)
                .HasMaxLength(150)
                .HasDefaultValueSql("''")
                .HasColumnName("tytul_emaila");
            entity.Property(e => e.UidProsby)
                .HasMaxLength(255)
                .HasColumnName("uid_prosby");

            entity.HasOne(d => d.Produktyzapisane).WithMany(p => p.Produktyzapisaneakceptacjas)
                .HasForeignKey(d => d.ProduktyzapisaneId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("produktyzapisaneakceptacja_FK_1");
        });

        modelBuilder.Entity<Produktyzdefiniowane>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("produktyzdefiniowane");

            entity.HasIndex(e => e.SzablonyproduktowId, "produktyzdefiniowane_FI_1");

            entity.HasIndex(e => e.UzytkownicyId, "produktyzdefiniowane_FI_2");

            entity.HasIndex(e => e.UuidPrzestrzeni, "produktyzdefiniowane_I_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Konfiguracja)
                .HasColumnType("text")
                .HasColumnName("konfiguracja");
            entity.Property(e => e.Salt)
                .HasMaxLength(255)
                .HasColumnName("salt");
            entity.Property(e => e.SzablonyproduktowId)
                .HasColumnType("int(11)")
                .HasColumnName("szablonyproduktow_id");
            entity.Property(e => e.UuidPrzestrzeni)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("uuid_przestrzeni");
            entity.Property(e => e.UzytkownicyId)
                .HasColumnType("int(11)")
                .HasColumnName("uzytkownicy_id");
        });

        modelBuilder.Entity<ProjektyKonkursowe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("projekty_konkursowe");

            entity.HasIndex(e => e.IdKonkursu, "projekty_konkursowe_FI_1");

            entity.HasIndex(e => e.IdProjektuTymczasowego, "projekty_konkursowe_FI_2");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DataAktualizacji)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("data_aktualizacji");
            entity.Property(e => e.DataUtworzenia)
                .HasMaxLength(20)
                .HasColumnName("data_utworzenia");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .HasColumnName("email");
            entity.Property(e => e.FacebookComments)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("facebook_comments");
            entity.Property(e => e.FacebookLike)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("facebook_like");
            entity.Property(e => e.FacebookShare)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("facebook_share");
            entity.Property(e => e.GooglePlus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("google_plus");
            entity.Property(e => e.GooglePlusShare)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("google_plus_share");
            entity.Property(e => e.IdKonkursu)
                .HasColumnType("int(11)")
                .HasColumnName("id_konkursu");
            entity.Property(e => e.IdProjektuTymczasowego)
                .HasColumnType("int(11)")
                .HasColumnName("id_projektu_tymczasowego");
            entity.Property(e => e.SaltProjektuTymczasowego)
                .HasMaxLength(255)
                .HasColumnName("salt_projektu_tymczasowego");
            entity.Property(e => e.Total)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("total");
            entity.Property(e => e.TwitterShare)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("twitter_share");
        });

        modelBuilder.Entity<Przesylki>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("przesylki");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Data)
                .HasMaxLength(20)
                .HasColumnName("data");
            entity.Property(e => e.DoAdres)
                .HasMaxLength(255)
                .HasColumnName("do_adres");
            entity.Property(e => e.DoEmail)
                .HasMaxLength(60)
                .HasColumnName("do_email");
            entity.Property(e => e.DoImieNazwisko)
                .HasMaxLength(120)
                .HasColumnName("do_imie_nazwisko");
            entity.Property(e => e.DoKodPocztowy)
                .HasMaxLength(12)
                .HasColumnName("do_kod_pocztowy");
            entity.Property(e => e.DoKraj)
                .HasMaxLength(6)
                .HasDefaultValueSql("'PL'")
                .HasColumnName("do_kraj");
            entity.Property(e => e.DoMiejscowosc)
                .HasMaxLength(255)
                .HasColumnName("do_miejscowosc");
            entity.Property(e => e.DoNazwaFirmy)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("do_nazwa_firmy");
            entity.Property(e => e.DoTelefon)
                .HasMaxLength(20)
                .HasColumnName("do_telefon");
            entity.Property(e => e.Dodatkowe).HasColumnName("dodatkowe");
            entity.Property(e => e.NumerListuPrzewozowego)
                .HasMaxLength(100)
                .HasColumnName("numer_listu_przewozowego");
            entity.Property(e => e.Opis)
                .HasColumnType("text")
                .HasColumnName("opis");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");
            entity.Property(e => e.TypKuriera)
                .HasColumnType("int(11)")
                .HasColumnName("typ_kuriera");
            entity.Property(e => e.TypPliku)
                .HasMaxLength(5)
                .HasColumnName("typ_pliku");
            entity.Property(e => e.TypPrzesylki)
                .HasColumnType("int(11)")
                .HasColumnName("typ_przesylki");
            entity.Property(e => e.Uid)
                .HasMaxLength(255)
                .HasColumnName("uid");
            entity.Property(e => e.ZAdres)
                .HasMaxLength(255)
                .HasColumnName("z_adres");
            entity.Property(e => e.ZEmail)
                .HasMaxLength(60)
                .HasColumnName("z_email");
            entity.Property(e => e.ZImieNazwisko)
                .HasMaxLength(120)
                .HasColumnName("z_imie_nazwisko");
            entity.Property(e => e.ZKodPocztowy)
                .HasMaxLength(12)
                .HasColumnName("z_kod_pocztowy");
            entity.Property(e => e.ZKraj)
                .HasMaxLength(6)
                .HasDefaultValueSql("'PL'")
                .HasColumnName("z_kraj");
            entity.Property(e => e.ZMiejscowosc)
                .HasMaxLength(255)
                .HasColumnName("z_miejscowosc");
            entity.Property(e => e.ZNazwaFirmy)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("z_nazwa_firmy");
            entity.Property(e => e.ZTelefon)
                .HasMaxLength(20)
                .HasColumnName("z_telefon");
            entity.Property(e => e.ZamowienieKwotaBrutto)
                .HasMaxLength(10)
                .HasDefaultValueSql("'0'")
                .HasColumnName("zamowienie_kwota_brutto");
        });

        modelBuilder.Entity<PrzesylkiKonfiguracja>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("przesylki_konfiguracja");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CzyDarmowaDostawa)
                .HasColumnType("tinyint(4)")
                .HasColumnName("czy_darmowa_dostawa");
            entity.Property(e => e.CzyDomyslne)
                .HasColumnType("tinyint(4)")
                .HasColumnName("czy_domyslne");
            entity.Property(e => e.KwotaBrutto)
                .HasMaxLength(10)
                .HasColumnName("kwota_brutto");
            entity.Property(e => e.KwotaZamowieniaDarmowejDostawy)
                .HasMaxLength(10)
                .HasColumnName("kwota_zamowienia_darmowej_dostawy");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(100)
                .HasColumnName("nazwa");
            entity.Property(e => e.Visible)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<Przesylkizamowienium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("przesylkizamowienia");

            entity.HasIndex(e => e.PrzesylkiId, "przesylkizamowienia_FI_1");

            entity.HasIndex(e => e.ZamowienieId, "przesylkizamowienia_FI_2");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.PrzesylkiId)
                .HasColumnType("int(11)")
                .HasColumnName("przesylki_id");
            entity.Property(e => e.ZamowienieId)
                .HasColumnType("int(11)")
                .HasColumnName("zamowienie_id");
        });

        modelBuilder.Entity<RodzajeDostawy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("rodzaje_dostawy");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Identyfikator)
                .HasColumnType("int(11)")
                .HasColumnName("identyfikator");
            entity.Property(e => e.Kolejnosc)
                .HasColumnType("int(11)")
                .HasColumnName("kolejnosc");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("nazwa");
            entity.Property(e => e.NazwaDe)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("nazwa_de");
            entity.Property(e => e.NazwaEn)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("nazwa_en");
        });

        modelBuilder.Entity<Rodzajemaili>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("rodzajemaili");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Rodzaj)
                .HasColumnType("int(11)")
                .HasColumnName("rodzaj");
        });

        modelBuilder.Entity<Rodzajepapieru>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("rodzajepapieru");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(30)
                .HasColumnName("nazwa");
            entity.Property(e => e.Opis)
                .HasMaxLength(200)
                .HasColumnName("opis");
        });

        modelBuilder.Entity<RozliczeniaListaZamowien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("rozliczenia_lista_zamowien");

            entity.HasIndex(e => e.RozliczeniaId, "rozliczenia_lista_zamowien_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.RozliczeniaId)
                .HasColumnType("int(11)")
                .HasColumnName("rozliczenia_id");
            entity.Property(e => e.ZamowienieId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("zamowienie_id");
        });

        modelBuilder.Entity<Rozliczenium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("rozliczenia");

            entity.HasIndex(e => e.UserId, "rozliczenia_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DataDo)
                .HasMaxLength(20)
                .HasColumnName("data_do");
            entity.Property(e => e.DataOd)
                .HasMaxLength(20)
                .HasColumnName("data_od");
            entity.Property(e => e.DataRozliczenia)
                .HasMaxLength(20)
                .HasColumnName("data_rozliczenia");
            entity.Property(e => e.KwotaBruttoPrzesylki)
                .HasMaxLength(20)
                .HasColumnName("kwota_brutto_przesylki");
            entity.Property(e => e.KwotaBruttoZamowien)
                .HasMaxLength(20)
                .HasColumnName("kwota_brutto_zamowien");
            entity.Property(e => e.KwotaRozliczenia)
                .HasMaxLength(20)
                .HasColumnName("kwota_rozliczenia");
            entity.Property(e => e.NazwaPliku)
                .HasMaxLength(100)
                .HasColumnName("nazwa_pliku");
            entity.Property(e => e.NazwaPlikuKlienta)
                .HasMaxLength(100)
                .HasColumnName("nazwa_pliku_klienta");
            entity.Property(e => e.NumerRozliczenia)
                .HasMaxLength(20)
                .HasColumnName("numer_rozliczenia");
            entity.Property(e => e.OdbiorcaRozliczenia)
                .HasMaxLength(255)
                .HasColumnName("odbiorca_rozliczenia");
            entity.Property(e => e.Opis)
                .HasMaxLength(255)
                .HasColumnName("opis");
            entity.Property(e => e.PodstawaProwizji)
                .HasMaxLength(20)
                .HasColumnName("podstawa_prowizji");
            entity.Property(e => e.Rozliczone)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("rozliczone");
            entity.Property(e => e.Tresc)
                .HasColumnType("text")
                .HasColumnName("tresc");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
            entity.Property(e => e.WystawcaRozliczenia)
                .HasMaxLength(255)
                .HasColumnName("wystawca_rozliczenia");
        });

        modelBuilder.Entity<SkrzynkaKontaktowa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("skrzynka_kontaktowa");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AdresEmail)
                .HasMaxLength(255)
                .HasColumnName("adres_email");
            entity.Property(e => e.CzySprawdzono)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("czy_sprawdzono");
            entity.Property(e => e.ImieINazwisko)
                .HasMaxLength(255)
                .HasColumnName("imie_i_nazwisko");
            entity.Property(e => e.Temat)
                .HasMaxLength(255)
                .HasColumnName("temat");
            entity.Property(e => e.Tresc)
                .HasColumnType("text")
                .HasColumnName("tresc");
        });

        modelBuilder.Entity<Statystyka>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("statystyka");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Howlong)
                .HasMaxLength(10)
                .HasColumnName("howlong");
            entity.Property(e => e.Lastpage)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("lastpage");
            entity.Property(e => e.NextPagename)
                .HasColumnType("text")
                .HasColumnName("next_pagename");
            entity.Property(e => e.NextShortpagename)
                .HasMaxLength(80)
                .HasColumnName("next_shortpagename");
            entity.Property(e => e.Pagename)
                .HasColumnType("text")
                .HasColumnName("pagename");
            entity.Property(e => e.Requesttype)
                .HasMaxLength(10)
                .HasColumnName("requesttype");
            entity.Property(e => e.Shortpagename)
                .HasMaxLength(80)
                .HasColumnName("shortpagename");
            entity.Property(e => e.Timestamp)
                .HasMaxLength(20)
                .HasColumnName("timestamp");
            entity.Property(e => e.Uid)
                .HasMaxLength(255)
                .HasColumnName("uid");
        });

        modelBuilder.Entity<StatystykiZamowien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("statystyki_zamowien");

            entity.HasIndex(e => e.UserId, "statystyki_zamowien_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DataStatystyki)
                .HasMaxLength(20)
                .HasColumnName("data_statystyki");
            entity.Property(e => e.KwotaPrzesylkaOplacone)
                .HasMaxLength(20)
                .HasColumnName("kwota_przesylka_oplacone");
            entity.Property(e => e.KwotaPrzesylkaStrukturaOplacone)
                .HasMaxLength(20)
                .HasColumnName("kwota_przesylka_struktura_oplacone");
            entity.Property(e => e.KwotaPrzesylkaStrukturaZlozone)
                .HasMaxLength(20)
                .HasColumnName("kwota_przesylka_struktura_zlozone");
            entity.Property(e => e.KwotaPrzesylkaZlozone)
                .HasMaxLength(20)
                .HasColumnName("kwota_przesylka_zlozone");
            entity.Property(e => e.KwotaZamowieniaOplacone)
                .HasMaxLength(20)
                .HasColumnName("kwota_zamowienia_oplacone");
            entity.Property(e => e.KwotaZamowieniaStrukturaOplacone)
                .HasMaxLength(20)
                .HasColumnName("kwota_zamowienia_struktura_oplacone");
            entity.Property(e => e.KwotaZamowieniaStrukturaZlozone)
                .HasMaxLength(20)
                .HasColumnName("kwota_zamowienia_struktura_zlozone");
            entity.Property(e => e.KwotaZamowieniaZlozone)
                .HasMaxLength(20)
                .HasColumnName("kwota_zamowienia_zlozone");
            entity.Property(e => e.StrukturaProwizja)
                .HasMaxLength(20)
                .HasColumnName("struktura_prowizja");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<Stronastartowa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("stronastartowa");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Komunikat)
                .HasColumnType("text")
                .HasColumnName("komunikat");
            entity.Property(e => e.Slider)
                .HasColumnType("text")
                .HasColumnName("slider");
        });

        modelBuilder.Entity<Szablonyopisseo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("szablonyopisseo");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Alt)
                .HasMaxLength(200)
                .HasColumnName("alt");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.Dlakogo)
                .HasMaxLength(200)
                .HasColumnName("dlakogo");
            entity.Property(e => e.Keywords)
                .HasMaxLength(200)
                .HasColumnName("keywords");
            entity.Property(e => e.Link)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("link");
            entity.Property(e => e.Naglowek)
                .HasMaxLength(200)
                .HasColumnName("naglowek");
            entity.Property(e => e.NaglowekPrzod)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("naglowek_przod");
            entity.Property(e => e.NaglowekTyl)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("naglowek_tyl");
            entity.Property(e => e.Opis)
                .HasColumnType("text")
                .HasColumnName("opis");
            entity.Property(e => e.SzablonId)
                .HasColumnType("int(11)")
                .HasColumnName("szablon_id");
            entity.Property(e => e.Tagi)
                .HasMaxLength(200)
                .HasColumnName("tagi");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Szablonyproduktow>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("szablonyproduktow");

            entity.HasIndex(e => e.KategorieId, "szablonyproduktow_FI_1");

            entity.HasIndex(e => e.FormatyId, "szablonyproduktow_FI_2");

            entity.HasIndex(e => e.PodkategorieId, "szablonyproduktow_FI_3");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DefaultReverseTag)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("default_reverse_tag");
            entity.Property(e => e.FormatyId)
                .HasColumnType("int(11)")
                .HasColumnName("formaty_id");
            entity.Property(e => e.KategorieId)
                .HasColumnType("int(11)")
                .HasColumnName("kategorie_id");
            entity.Property(e => e.Konfiguracja)
                .HasColumnType("text")
                .HasColumnName("konfiguracja");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(200)
                .HasColumnName("nazwa");
            entity.Property(e => e.OptionsTags)
                .HasColumnType("text")
                .HasColumnName("options_tags");
            entity.Property(e => e.PlikSzablonu)
                .HasMaxLength(150)
                .HasColumnName("plik_szablonu");
            entity.Property(e => e.PodkategorieId)
                .HasColumnType("int(11)")
                .HasColumnName("podkategorie_id");
            entity.Property(e => e.PokazNaStronieGlownejGalerii)
                .HasColumnType("tinyint(4)")
                .HasColumnName("pokaz_na_stronie_glownej_galerii");
            entity.Property(e => e.PokazWGalerii)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("pokaz_w_galerii");
            entity.Property(e => e.Rank)
                .HasColumnType("int(11)")
                .HasColumnName("rank");
            entity.Property(e => e.ReverseTags)
                .HasColumnType("text")
                .HasColumnName("reverse_tags");
            entity.Property(e => e.TagName)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("tag_name");
        });

        modelBuilder.Entity<Tempimagegroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tempimagegroup");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Datautworzenia)
                .HasColumnType("datetime")
                .HasColumnName("datautworzenia");
            entity.Property(e => e.PlikGrupy)
                .HasMaxLength(150)
                .HasColumnName("plik_grupy");
            entity.Property(e => e.Salt)
                .HasMaxLength(150)
                .HasColumnName("salt");
        });

        modelBuilder.Entity<Uzytkownicy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("uzytkownicy");

            entity.HasIndex(e => e.ParentUserId, "uzytkownicy_FI_1");

            entity.HasIndex(e => e.RootUserId, "uzytkownicy_FI_2");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("active");
            entity.Property(e => e.Activeeditor)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("activeeditor");
            entity.Property(e => e.Adres)
                .HasMaxLength(255)
                .HasColumnName("adres");
            entity.Property(e => e.CzestotliwoscWystawianiaFaktury)
                .HasColumnType("tinyint(4)")
                .HasColumnName("czestotliwosc_wystawiania_faktury");
            entity.Property(e => e.CzyAkceptujaFaktureElektroniczna)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("czy_akceptuja_fakture_elektroniczna");
            entity.Property(e => e.CzyGenerowacFaktureAutomatycznie)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("czy_generowac_fakture_automatycznie");
            entity.Property(e => e.CzyGenerowacFaktureZbiorczo)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("czy_generowac_fakture_zbiorczo");
            entity.Property(e => e.CzyKontrahenci)
                .HasColumnType("tinyint(4)")
                .HasColumnName("czy_kontrahenci");
            entity.Property(e => e.CzyKoszty)
                .HasColumnType("tinyint(4)")
                .HasColumnName("czy_koszty");
            entity.Property(e => e.CzyWysylacFaktureEmail2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("czy_wysylac_fakture_email2");
            entity.Property(e => e.DataAktywacji)
                .HasMaxLength(20)
                .HasColumnName("data_aktywacji");
            entity.Property(e => e.DataRejestracji)
                .HasMaxLength(20)
                .HasColumnName("data_rejestracji");
            entity.Property(e => e.DomyslnaFormaPlatnosci)
                .HasMaxLength(50)
                .HasColumnName("domyslna_forma_platnosci");
            entity.Property(e => e.DomyslnyRachunekBankowy)
                .HasDefaultValueSql("'-1'")
                .HasColumnType("int(11)")
                .HasColumnName("domyslny_rachunek_bankowy");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .HasColumnName("email");
            entity.Property(e => e.Email10)
                .HasMaxLength(60)
                .HasColumnName("email10");
            entity.Property(e => e.Email10AktywnaPrzestrzen)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email10_aktywna_przestrzen");
            entity.Property(e => e.Email10AktywnaPrzestrzen2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email10_aktywna_przestrzen2");
            entity.Property(e => e.Email10AktywnaPrzestrzen3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email10_aktywna_przestrzen3");
            entity.Property(e => e.Email2)
                .HasMaxLength(60)
                .HasColumnName("email2");
            entity.Property(e => e.Email2AktywnaPrzestrzen)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email2_aktywna_przestrzen");
            entity.Property(e => e.Email2AktywnaPrzestrzen2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email2_aktywna_przestrzen2");
            entity.Property(e => e.Email2AktywnaPrzestrzen3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email2_aktywna_przestrzen3");
            entity.Property(e => e.Email3)
                .HasMaxLength(60)
                .HasColumnName("email3");
            entity.Property(e => e.Email3AktywnaPrzestrzen)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email3_aktywna_przestrzen");
            entity.Property(e => e.Email3AktywnaPrzestrzen2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email3_aktywna_przestrzen2");
            entity.Property(e => e.Email3AktywnaPrzestrzen3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email3_aktywna_przestrzen3");
            entity.Property(e => e.Email4)
                .HasMaxLength(60)
                .HasColumnName("email4");
            entity.Property(e => e.Email4AktywnaPrzestrzen)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email4_aktywna_przestrzen");
            entity.Property(e => e.Email4AktywnaPrzestrzen2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email4_aktywna_przestrzen2");
            entity.Property(e => e.Email4AktywnaPrzestrzen3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email4_aktywna_przestrzen3");
            entity.Property(e => e.Email5)
                .HasMaxLength(60)
                .HasColumnName("email5");
            entity.Property(e => e.Email5AktywnaPrzestrzen)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email5_aktywna_przestrzen");
            entity.Property(e => e.Email5AktywnaPrzestrzen2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email5_aktywna_przestrzen2");
            entity.Property(e => e.Email5AktywnaPrzestrzen3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email5_aktywna_przestrzen3");
            entity.Property(e => e.Email6)
                .HasMaxLength(60)
                .HasColumnName("email6");
            entity.Property(e => e.Email6AktywnaPrzestrzen)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email6_aktywna_przestrzen");
            entity.Property(e => e.Email6AktywnaPrzestrzen2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email6_aktywna_przestrzen2");
            entity.Property(e => e.Email6AktywnaPrzestrzen3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email6_aktywna_przestrzen3");
            entity.Property(e => e.Email7)
                .HasMaxLength(60)
                .HasColumnName("email7");
            entity.Property(e => e.Email7AktywnaPrzestrzen)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email7_aktywna_przestrzen");
            entity.Property(e => e.Email7AktywnaPrzestrzen2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email7_aktywna_przestrzen2");
            entity.Property(e => e.Email7AktywnaPrzestrzen3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email7_aktywna_przestrzen3");
            entity.Property(e => e.Email8)
                .HasMaxLength(60)
                .HasColumnName("email8");
            entity.Property(e => e.Email8AktywnaPrzestrzen)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email8_aktywna_przestrzen");
            entity.Property(e => e.Email8AktywnaPrzestrzen2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email8_aktywna_przestrzen2");
            entity.Property(e => e.Email8AktywnaPrzestrzen3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email8_aktywna_przestrzen3");
            entity.Property(e => e.Email9)
                .HasMaxLength(60)
                .HasColumnName("email9");
            entity.Property(e => e.Email9AktywnaPrzestrzen)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email9_aktywna_przestrzen");
            entity.Property(e => e.Email9AktywnaPrzestrzen2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email9_aktywna_przestrzen2");
            entity.Property(e => e.Email9AktywnaPrzestrzen3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email9_aktywna_przestrzen3");
            entity.Property(e => e.EmailAktywnaPrzestrzen)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email_aktywna_przestrzen");
            entity.Property(e => e.EmailAktywnaPrzestrzen2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email_aktywna_przestrzen2");
            entity.Property(e => e.EmailAktywnaPrzestrzen3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("email_aktywna_przestrzen3");
            entity.Property(e => e.EmailDoFaktury)
                .HasMaxLength(100)
                .HasColumnName("email_do_faktury");
            entity.Property(e => e.EmailDoFaktury2)
                .HasMaxLength(100)
                .HasColumnName("email_do_faktury2");
            entity.Property(e => e.EmailPrefix)
                .HasMaxLength(120)
                .HasColumnName("email_prefix");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .HasColumnName("fax");
            entity.Property(e => e.Haslo)
                .HasMaxLength(255)
                .HasColumnName("haslo");
            entity.Property(e => e.Haslo10)
                .HasMaxLength(255)
                .HasColumnName("haslo10");
            entity.Property(e => e.Haslo2)
                .HasMaxLength(255)
                .HasColumnName("haslo2");
            entity.Property(e => e.Haslo3)
                .HasMaxLength(255)
                .HasColumnName("haslo3");
            entity.Property(e => e.Haslo4)
                .HasMaxLength(255)
                .HasColumnName("haslo4");
            entity.Property(e => e.Haslo5)
                .HasMaxLength(255)
                .HasColumnName("haslo5");
            entity.Property(e => e.Haslo6)
                .HasMaxLength(255)
                .HasColumnName("haslo6");
            entity.Property(e => e.Haslo7)
                .HasMaxLength(255)
                .HasColumnName("haslo7");
            entity.Property(e => e.Haslo8)
                .HasMaxLength(255)
                .HasColumnName("haslo8");
            entity.Property(e => e.Haslo9)
                .HasMaxLength(255)
                .HasColumnName("haslo9");
            entity.Property(e => e.ImieNazwisko)
                .HasMaxLength(120)
                .HasColumnName("imie_nazwisko");
            entity.Property(e => e.ImieNazwisko10)
                .HasMaxLength(120)
                .HasColumnName("imie_nazwisko10");
            entity.Property(e => e.ImieNazwisko2)
                .HasMaxLength(120)
                .HasColumnName("imie_nazwisko2");
            entity.Property(e => e.ImieNazwisko3)
                .HasMaxLength(120)
                .HasColumnName("imie_nazwisko3");
            entity.Property(e => e.ImieNazwisko4)
                .HasMaxLength(120)
                .HasColumnName("imie_nazwisko4");
            entity.Property(e => e.ImieNazwisko5)
                .HasMaxLength(120)
                .HasColumnName("imie_nazwisko5");
            entity.Property(e => e.ImieNazwisko6)
                .HasMaxLength(120)
                .HasColumnName("imie_nazwisko6");
            entity.Property(e => e.ImieNazwisko7)
                .HasMaxLength(120)
                .HasColumnName("imie_nazwisko7");
            entity.Property(e => e.ImieNazwisko8)
                .HasMaxLength(120)
                .HasColumnName("imie_nazwisko8");
            entity.Property(e => e.ImieNazwisko9)
                .HasMaxLength(120)
                .HasColumnName("imie_nazwisko9");
            entity.Property(e => e.Jezyk)
                .HasMaxLength(5)
                .HasColumnName("jezyk");
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("kod");
            entity.Property(e => e.KodPocztowy)
                .HasMaxLength(12)
                .HasColumnName("kod_pocztowy");
            entity.Property(e => e.KontaktOpis)
                .HasColumnType("text")
                .HasColumnName("kontakt_opis");
            entity.Property(e => e.Kraj)
                .HasMaxLength(5)
                .HasColumnName("kraj");
            entity.Property(e => e.Login)
                .HasMaxLength(60)
                .HasColumnName("login");
            entity.Property(e => e.Logo)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("logo");
            entity.Property(e => e.Miejscowosc)
                .HasMaxLength(255)
                .HasColumnName("miejscowosc");
            entity.Property(e => e.NazwaFirmy)
                .HasMaxLength(255)
                .HasColumnName("nazwa_firmy");
            entity.Property(e => e.NazwaKsiegowosci)
                .HasMaxLength(120)
                .HasColumnName("nazwa_ksiegowosci");
            entity.Property(e => e.Nip)
                .HasMaxLength(13)
                .HasColumnName("nip");
            entity.Property(e => e.NotatkaOPlatnosciach)
                .HasColumnType("text")
                .HasColumnName("notatka_o_platnosciach");
            entity.Property(e => e.ParentUserId)
                .HasColumnType("int(11)")
                .HasColumnName("parent_user_id");
            entity.Property(e => e.PlacePrefix)
                .HasMaxLength(120)
                .HasColumnName("place_prefix");
            entity.Property(e => e.ProgramPartnerski)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("program_partnerski");
            entity.Property(e => e.RootUserId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("root_user_id");
            entity.Property(e => e.SprzedawcaId)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("sprzedawca_id");
            entity.Property(e => e.Sumakontrolna)
                .HasMaxLength(255)
                .HasColumnName("sumakontrolna");
            entity.Property(e => e.Telefon)
                .HasMaxLength(20)
                .HasColumnName("telefon");
            entity.Property(e => e.Telefon10)
                .HasMaxLength(20)
                .HasColumnName("telefon10");
            entity.Property(e => e.Telefon2)
                .HasMaxLength(20)
                .HasColumnName("telefon2");
            entity.Property(e => e.Telefon3)
                .HasMaxLength(20)
                .HasColumnName("telefon3");
            entity.Property(e => e.Telefon4)
                .HasMaxLength(20)
                .HasColumnName("telefon4");
            entity.Property(e => e.Telefon5)
                .HasMaxLength(20)
                .HasColumnName("telefon5");
            entity.Property(e => e.Telefon6)
                .HasMaxLength(20)
                .HasColumnName("telefon6");
            entity.Property(e => e.Telefon7)
                .HasMaxLength(20)
                .HasColumnName("telefon7");
            entity.Property(e => e.Telefon8)
                .HasMaxLength(20)
                .HasColumnName("telefon8");
            entity.Property(e => e.Telefon9)
                .HasMaxLength(20)
                .HasColumnName("telefon9");
            entity.Property(e => e.TelefonKsiegowosci)
                .HasMaxLength(40)
                .HasColumnName("telefon_ksiegowosci");
            entity.Property(e => e.TerminPlatnosciFaktury)
                .HasMaxLength(3)
                .HasDefaultValueSql("'7'")
                .HasColumnName("termin_platnosci_faktury");
            entity.Property(e => e.TerminWystawianiaFakturyDzien)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("termin_wystawiania_faktury_dzien");
            entity.Property(e => e.TerminWystawianiaFakturyTydzien)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("termin_wystawiania_faktury_tydzien");
            entity.Property(e => e.TypKlienta)
                .HasMaxLength(10)
                .HasDefaultValueSql("'0'")
                .HasColumnName("typ_klienta");
            entity.Property(e => e.Vat)
                .HasDefaultValueSql("'23'")
                .HasColumnType("int(11)")
                .HasColumnName("VAT");
            entity.Property(e => e.WAdres)
                .HasMaxLength(255)
                .HasColumnName("w_adres");
            entity.Property(e => e.WKodPocztowy)
                .HasMaxLength(12)
                .HasColumnName("w_kod_pocztowy");
            entity.Property(e => e.WMiejscowosc)
                .HasMaxLength(255)
                .HasColumnName("w_miejscowosc");
            entity.Property(e => e.Waluta)
                .HasMaxLength(3)
                .HasColumnName("waluta");
            entity.Property(e => e.WewnetrznyTyp)
                .HasMaxLength(10)
                .HasDefaultValueSql("'0'")
                .HasColumnName("wewnetrzny_typ");
        });

        modelBuilder.Entity<Uzytkownicysystemowi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("uzytkownicysystemowi");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CzyAktywne)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("czy_aktywne");
            entity.Property(e => e.DataAktualizacji)
                .HasMaxLength(20)
                .HasColumnName("data_aktualizacji");
            entity.Property(e => e.DataOstatniegoLogowania)
                .HasMaxLength(20)
                .HasColumnName("data_ostatniego_logowania");
            entity.Property(e => e.DataPoprzedniegoLogowania)
                .HasMaxLength(20)
                .HasColumnName("data_poprzedniego_logowania");
            entity.Property(e => e.DataUtworzenia)
                .HasMaxLength(20)
                .HasColumnName("data_utworzenia");
            entity.Property(e => e.DataWaznosciTokena)
                .HasMaxLength(20)
                .HasColumnName("data_waznosci_tokena");
            entity.Property(e => e.DomyslnyWidokPoZalogowaniu)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("domyslny_widok_po_zalogowaniu");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .HasColumnName("email");
            entity.Property(e => e.Haslo)
                .HasMaxLength(100)
                .HasColumnName("haslo");
            entity.Property(e => e.Imie)
                .HasMaxLength(30)
                .HasColumnName("imie");
            entity.Property(e => e.Login)
                .HasMaxLength(60)
                .HasColumnName("login");
            entity.Property(e => e.ResetUid)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("reset_uid");
            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .HasColumnName("token");
            entity.Property(e => e.Uid)
                .HasMaxLength(255)
                .HasColumnName("uid");
            entity.Property(e => e.Uprawnienia)
                .HasColumnType("text")
                .HasColumnName("uprawnienia");
        });

        modelBuilder.Entity<UzytkownikHasloTymczasowe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("uzytkownik_haslo_tymczasowe");

            entity.HasIndex(e => e.UzytkownicyId, "uzytkownik_haslo_tymczasowe_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Checksum)
                .HasMaxLength(255)
                .HasColumnName("checksum");
            entity.Property(e => e.Data)
                .HasMaxLength(20)
                .HasColumnName("data");
            entity.Property(e => e.IndexProfilu)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("index_profilu");
            entity.Property(e => e.UzytkownicyId)
                .HasColumnType("int(11)")
                .HasColumnName("uzytkownicy_id");

            entity.HasOne(d => d.Uzytkownicy).WithMany(p => p.UzytkownikHasloTymczasowes)
                .HasForeignKey(d => d.UzytkownicyId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("uzytkownik_haslo_tymczasowe_FK_1");
        });

        modelBuilder.Entity<UzytkownikPrawa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("uzytkownik_prawa");

            entity.HasIndex(e => e.UzytkownicyId, "uzytkownik_prawa_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Konfiguracja)
                .HasColumnType("text")
                .HasColumnName("konfiguracja");
            entity.Property(e => e.UzytkownicyId)
                .HasColumnType("int(11)")
                .HasColumnName("uzytkownicy_id");

            entity.HasOne(d => d.Uzytkownicy).WithMany(p => p.UzytkownikPrawas)
                .HasForeignKey(d => d.UzytkownicyId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("uzytkownik_prawa_FK_1");
        });

        modelBuilder.Entity<VideoPomoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("video_pomoc");

            entity.HasIndex(e => e.PlikUuid, "video_pomoc_I_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Kolejnosc)
                .HasColumnType("int(11)")
                .HasColumnName("kolejnosc");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(255)
                .HasColumnName("nazwa");
            entity.Property(e => e.NazwaPliku)
                .HasMaxLength(255)
                .HasColumnName("nazwa_pliku");
            entity.Property(e => e.Opis)
                .HasColumnType("text")
                .HasColumnName("opis");
            entity.Property(e => e.PlikUuid)
                .HasMaxLength(36)
                .HasColumnName("plik_uuid");
            entity.Property(e => e.RootUserId)
                .HasColumnType("int(11)")
                .HasColumnName("root_user_id");
        });

        modelBuilder.Entity<WartosciParametrow>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("wartosci_parametrow");

            entity.HasIndex(e => e.IdParametr, "wartosci_parametrow_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.IdParametr)
                .HasColumnType("int(11)")
                .HasColumnName("id_parametr");
            entity.Property(e => e.Wartosc)
                .HasMaxLength(127)
                .HasColumnName("wartosc");
            entity.Property(e => e.Wartosc2)
                .HasMaxLength(127)
                .HasColumnName("wartosc2");
            entity.Property(e => e.Wartosc3)
                .HasMaxLength(127)
                .HasColumnName("wartosc3");

            entity.HasOne(d => d.IdParametrNavigation).WithMany(p => p.WartosciParametrows)
                .HasForeignKey(d => d.IdParametr)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("wartosci_parametrow_FK_1");
        });

        modelBuilder.Entity<Zamowieniaobsluga>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("zamowieniaobsluga");

            entity.HasIndex(e => e.ZamowienieId, "zamowieniaobsluga_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.OsobaId)
                .HasColumnType("int(11)")
                .HasColumnName("osoba_id");
            entity.Property(e => e.Status)
                .HasColumnType("int(11)")
                .HasColumnName("status");
            entity.Property(e => e.ZamowienieId)
                .HasColumnType("int(11)")
                .HasColumnName("zamowienie_id");
        });

        modelBuilder.Entity<Zamowienie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("zamowienie");

            entity.HasIndex(e => e.Data, "data");

            entity.HasIndex(e => e.FakturaId, "zamowienie_FI_1");

            entity.HasIndex(e => e.UuidPrzestrzeni, "zamowienie_I_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CzasRealizacji)
                .HasDefaultValueSql("'3'")
                .HasColumnType("int(11)")
                .HasColumnName("czas_realizacji");
            entity.Property(e => e.CzasRealizacjiKoniec)
                .HasColumnType("int(11)")
                .HasColumnName("czas_realizacji_koniec");
            entity.Property(e => e.CzasRealizacjiStart)
                .HasColumnType("int(11)")
                .HasColumnName("czas_realizacji_start");
            entity.Property(e => e.CzasZrealizowano)
                .HasColumnType("int(11)")
                .HasColumnName("czas_zrealizowano");
            entity.Property(e => e.CzyKoszty)
                .HasColumnType("tinyint(4)")
                .HasColumnName("czy_koszty");
            entity.Property(e => e.Data)
                .HasMaxLength(20)
                .HasColumnName("data");
            entity.Property(e => e.DataOstatniegoPrzypomnienia)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("data_ostatniego_przypomnienia");
            entity.Property(e => e.DataPlatnosci)
                .HasMaxLength(20)
                .HasColumnName("data_platnosci");
            entity.Property(e => e.DataTerminZaplaty)
                .HasMaxLength(20)
                .HasColumnName("data_termin_zaplaty");
            entity.Property(e => e.DataTerminZaplatyDni)
                .HasMaxLength(5)
                .HasDefaultValueSql("'0'")
                .HasColumnName("data_termin_zaplaty_dni");
            entity.Property(e => e.DataWystawienia)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("data_wystawienia");
            entity.Property(e => e.DoWyjasnienia)
                .HasColumnType("tinyint(4)")
                .HasColumnName("do_wyjasnienia");
            entity.Property(e => e.FAdres)
                .HasMaxLength(255)
                .HasColumnName("f_adres");
            entity.Property(e => e.FKodPocztowy)
                .HasMaxLength(12)
                .HasColumnName("f_kod_pocztowy");
            entity.Property(e => e.FMiejscowosc)
                .HasMaxLength(255)
                .HasColumnName("f_miejscowosc");
            entity.Property(e => e.FNazwaFirmyLubOsoby)
                .HasMaxLength(255)
                .HasColumnName("f_nazwa_firmy_lub_osoby");
            entity.Property(e => e.FNip)
                .HasMaxLength(20)
                .HasColumnName("f_nip");
            entity.Property(e => e.FakturaId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("faktura_id");
            entity.Property(e => e.FormaPlatnosci)
                .HasColumnType("int(11)")
                .HasColumnName("forma_platnosci");
            entity.Property(e => e.FormaPlatnosciOpis)
                .HasMaxLength(60)
                .HasDefaultValueSql("'płatność online'")
                .HasColumnName("forma_platnosci_opis");
            entity.Property(e => e.IdPaczkomatu)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("id_paczkomatu");
            entity.Property(e => e.KuponyrabatoweId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("kuponyrabatowe_id");
            entity.Property(e => e.KwotaBrutto)
                .HasMaxLength(100)
                .HasColumnName("kwota_brutto");
            entity.Property(e => e.NumerRachunkuBankowego)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("numer_rachunku_bankowego");
            entity.Property(e => e.NumerReferencyjny)
                .HasMaxLength(400)
                .HasDefaultValueSql("''")
                .HasColumnName("numer_referencyjny");
            entity.Property(e => e.OsobaPrywatna)
                .HasColumnType("tinyint(4)")
                .HasColumnName("osoba_prywatna");
            entity.Property(e => e.Payback)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("payback");
            entity.Property(e => e.PpName)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("pp_name");
            entity.Property(e => e.PpUserId)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("pp_user_id");
            entity.Property(e => e.PrzesylkaKwotaBrutto)
                .HasMaxLength(50)
                .HasColumnName("przesylka_kwota_brutto");
            entity.Property(e => e.SposobDostawy)
                .HasDefaultValueSql("'2'")
                .HasColumnType("int(11)")
                .HasColumnName("sposob_dostawy");
            entity.Property(e => e.SprzedawcaId)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("sprzedawca_id");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");
            entity.Property(e => e.Uid)
                .HasMaxLength(255)
                .HasColumnName("uid");
            entity.Property(e => e.UuidPrzestrzeni)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("uuid_przestrzeni");
            entity.Property(e => e.Uwagi)
                .HasColumnType("text")
                .HasColumnName("uwagi");
            entity.Property(e => e.UwagiKlienta)
                .HasColumnType("text")
                .HasColumnName("uwagi_klienta");
            entity.Property(e => e.UzytkownicyId)
                .HasColumnType("int(11)")
                .HasColumnName("uzytkownicy_id");
            entity.Property(e => e.WAdres)
                .HasMaxLength(255)
                .HasColumnName("w_adres");
            entity.Property(e => e.WEmail)
                .HasMaxLength(60)
                .HasColumnName("w_email");
            entity.Property(e => e.WImieNazwisko)
                .HasMaxLength(120)
                .HasColumnName("w_imie_nazwisko");
            entity.Property(e => e.WKodPocztowy)
                .HasMaxLength(12)
                .HasColumnName("w_kod_pocztowy");
            entity.Property(e => e.WKraj)
                .HasMaxLength(6)
                .HasDefaultValueSql("'PL'")
                .HasColumnName("w_kraj");
            entity.Property(e => e.WMiejscowosc)
                .HasMaxLength(255)
                .HasColumnName("w_miejscowosc");
            entity.Property(e => e.WNazwaFirmy)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("w_nazwa_firmy");
            entity.Property(e => e.WTelefon)
                .HasMaxLength(20)
                .HasColumnName("w_telefon");
            entity.Property(e => e.Waluta)
                .HasMaxLength(3)
                .HasColumnName("waluta");
            entity.Property(e => e.WystawEFakture)
                .HasColumnType("tinyint(4)")
                .HasColumnName("wystaw_e_fakture");
            entity.Property(e => e.WystawionoProwizjePp)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("wystawiono_prowizje_pp");
            entity.Property(e => e.ZEmail)
                .HasMaxLength(60)
                .HasColumnName("z_email");
            entity.Property(e => e.ZImieNazwisko)
                .HasMaxLength(120)
                .HasColumnName("z_imie_nazwisko");
            entity.Property(e => e.ZTelefon)
                .HasMaxLength(20)
                .HasColumnName("z_telefon");
            entity.Property(e => e.Zafakturowac)
                .HasColumnType("tinyint(4)")
                .HasColumnName("zafakturowac");
            entity.Property(e => e.ZamowienieZewnetrzne)
                .HasColumnType("tinyint(4)")
                .HasColumnName("zamowienie_zewnetrzne");
            entity.Property(e => e.ZgodaPrzetwarzaniedanych)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("zgoda_przetwarzaniedanych");
            entity.Property(e => e.ZgodaRegulamin)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("zgoda_regulamin");
        });

        modelBuilder.Entity<Zapytaniafirmaplu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("zapytaniafirmaplus");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .HasColumnName("email");
            entity.Property(e => e.ImieNazwisko)
                .HasMaxLength(120)
                .HasColumnName("imie_nazwisko");
            entity.Property(e => e.LiczbaPakietow)
                .HasMaxLength(20)
                .HasColumnName("liczba_pakietow");
            entity.Property(e => e.LiczbaPracownikow)
                .HasMaxLength(20)
                .HasColumnName("liczba_pracownikow");
            entity.Property(e => e.NazwaFirmy)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("nazwa_firmy");
            entity.Property(e => e.Telefon)
                .HasMaxLength(20)
                .HasColumnName("telefon");
            entity.Property(e => e.Temat)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("temat");
            entity.Property(e => e.Tresc)
                .HasColumnType("text")
                .HasColumnName("tresc");
        });

        modelBuilder.Entity<Zapytaniakontakt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("zapytaniakontakt");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .HasColumnName("email");
            entity.Property(e => e.Imie)
                .HasMaxLength(20)
                .HasColumnName("imie");
            entity.Property(e => e.NazwaFirmy)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("nazwa_firmy");
            entity.Property(e => e.Nazwisko)
                .HasMaxLength(40)
                .HasColumnName("nazwisko");
            entity.Property(e => e.Telefon)
                .HasMaxLength(20)
                .HasColumnName("telefon");
            entity.Property(e => e.Temat)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("temat");
            entity.Property(e => e.Tresc)
                .HasColumnType("text")
                .HasColumnName("tresc");
        });

        modelBuilder.Entity<Zapytaniaofertowe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("zapytaniaofertowe");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .HasColumnName("email");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .HasColumnName("fax");
            entity.Property(e => e.Imie)
                .HasMaxLength(20)
                .HasColumnName("imie");
            entity.Property(e => e.Kolorystyka)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("kolorystyka");
            entity.Property(e => e.NazwaFirmy)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("nazwa_firmy");
            entity.Property(e => e.Nazwisko)
                .HasMaxLength(40)
                .HasColumnName("nazwisko");
            entity.Property(e => e.Nip)
                .HasMaxLength(13)
                .HasColumnName("nip");
            entity.Property(e => e.Przyklady)
                .HasColumnType("text")
                .HasColumnName("przyklady");
            entity.Property(e => e.Stanowisko)
                .HasMaxLength(80)
                .HasColumnName("stanowisko");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("status");
            entity.Property(e => e.Telefon)
                .HasMaxLength(20)
                .HasColumnName("telefon");
            entity.Property(e => e.Telefon2)
                .HasMaxLength(20)
                .HasColumnName("telefon2");
            entity.Property(e => e.Uwagi)
                .HasColumnType("text")
                .HasColumnName("uwagi");
        });

        modelBuilder.Entity<ZdaniaSynonimy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("zdania_synonimy");

            entity.HasIndex(e => e.ZdaniaId, "zdania_synonimy_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Tekst)
                .HasColumnType("text")
                .HasColumnName("tekst");
            entity.Property(e => e.ZdaniaId)
                .HasColumnType("int(11)")
                .HasColumnName("zdania_id");
        });

        modelBuilder.Entity<Zdanium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("zdania");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Tekst)
                .HasColumnType("text")
                .HasColumnName("tekst");
        });

        modelBuilder.Entity<Zrodlaodwiedzin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("zrodlaodwiedzin");

            entity.HasIndex(e => e.ZamowienieId, "zrodlaodwiedzin_FI_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CampaignContent)
                .HasMaxLength(70)
                .HasColumnName("campaign_content");
            entity.Property(e => e.CampaignMedium)
                .HasMaxLength(70)
                .HasColumnName("campaign_medium");
            entity.Property(e => e.CampaignName)
                .HasMaxLength(70)
                .HasColumnName("campaign_name");
            entity.Property(e => e.CampaignSource)
                .HasMaxLength(70)
                .HasColumnName("campaign_source");
            entity.Property(e => e.CampaignTerm)
                .HasMaxLength(70)
                .HasColumnName("campaign_term");
            entity.Property(e => e.CurrentVisitStarted)
                .HasMaxLength(30)
                .HasColumnName("current_visit_started");
            entity.Property(e => e.FirstVisit)
                .HasMaxLength(30)
                .HasColumnName("first_visit");
            entity.Property(e => e.PagesViewed)
                .HasMaxLength(30)
                .HasColumnName("pages_viewed");
            entity.Property(e => e.PreviousVisit)
                .HasMaxLength(30)
                .HasColumnName("previous_visit");
            entity.Property(e => e.TimesVisited)
                .HasMaxLength(30)
                .HasColumnName("times_visited");
            entity.Property(e => e.ZamowienieId)
                .HasColumnType("int(11)")
                .HasColumnName("zamowienie_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
