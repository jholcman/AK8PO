Zamestnanci
    [Id]                    INT          IDENTITY (1, 1) NOT NULL,
    [prijmeni]              TEXT         NOT NULL,
    [jmeno]                 TEXT         NULL,
    [titul_pred]            VARCHAR (50) NULL,
    [titul_za]              VARCHAR (50) NULL,
    [telefon_pracovni]      VARCHAR (50) NULL,
    [telefon_soukromy]      VARCHAR (50) NULL,
    [email_pracovni]        TEXT         NULL,
    [email_soukromy]        TEXT         NULL,
    [kancelar]              VARCHAR (50) NULL,
    [uvazek]                FLOAT (53)   NULL,
    [doktorant]             CHAR (10)    DEFAULT ('Ne') NOT NULL,
    [pracovni_body_bez_ang] INT          NULL,
    [pracovni_body_s_ang]   INT          NULL,

Predmet
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [zkratka]        VARCHAR (20)  NULL,
    [pocet_tydnu]    INT           NULL,
    [prednasky]      INT           NULL,
    [cviceni]        INT           NULL,
    [seminare]       INT           NULL,
    [zakonceni]      VARCHAR (20)  NULL,
    [jazyk]          VARCHAR (20)  NULL,
    [velikost_tridy] INT           NULL,
    [nazev_predmetu] VARCHAR (100) NULL,
    [pocet_kreditu]  INT           NULL,
    [garant_ustav]   VARCHAR (20)  NULL,
    [garant_osoba]   VARCHAR (100) NULL,
    
Studenti
    [Id]             INT          IDENTITY (1, 1) NOT NULL,
    [zkratka]        VARCHAR (10) NULL,
    [rocnik]         INT          NULL,
    [semestr]        VARCHAR (6)  NULL,
    [pocet_studentu] INT          NULL,
    [forma_studia]   VARCHAR (6)  NULL,
    [typ_studia]     VARCHAR (10) NULL,
    [jazyk]          VARCHAR (65) NULL,
    [nazev_studia]   VARCHAR (50) NULL,

[Stitky
    [Id] INT NOT NULL PRIMARY KEY, 
    [id_predmet] INT NULL, 
    [id_zamestnanec] INT NULL, 
    [rocnik] INT NULL, 
    [druh_stitku] INT NULL, 
    [hodnota_stitku] INT NULL, 
    [hodnota_stitku_d] FLOAT NULL

[Rozvrh
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Id_predmet] INT NOT NULL, 
    [Id_studenti] NCHAR(10) NOT NULL
    
[Global
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [text]    VARCHAR (100) NULL,
    [hodnota] FLOAT (53)    DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
