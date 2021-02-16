Zamestnanci
  	[Id] INT NOT NULL PRIMARY KEY, 
    [prijmeni] TEXT NOT NULL, 
    [jmeno] TEXT NULL, 
    [titul_pred] VARCHAR(50) NULL, 
    [titul_za] VARCHAR(50) NULL, 
    [telefon_prace] VARCHAR(50) NULL, 
    [telefon_mobil] VARCHAR(50) NULL, 
    [email] TEXT NULL, 
    [kancelar] VARCHAR(50) NULL, 
    [pozice] VARCHAR(50) NULL, 
    [uvazek] FLOAT NULL, 
    [doktorant] BIT NULL DEFAULT 0, 
    [pracovni_body_bez_ang] FLOAT NULL, 
    [pracovni_body_s_ang] FLOAT NULL

Predmet
  	[Id] INT NOT NULL PRIMARY KEY, 
    [zkratka] VARCHAR(20) NULL, 
    [nazev_predmetu] VARCHAR(100) NULL, 
    [vyucujici_id] INT NULL, 
    [zs_p] INT NULL, 
    [zs_s] INT NULL, 
    [zs_c] INT NULL, 
    [zs_zakonceni] VARCHAR(20) NULL,
    [zs_kredit] INT NULL,
    [ls_p] INT NULL, 
    [ls_s] INT NULL, 
    [ls_c] INT NULL, 
    [ls_kredit] INT NULL, 
    [ls_zakonceni] VARCHAR(20) NULL, 
    [forma_studia_k_p] VARCHAR(2) NULL, 
    [studijni_obor] VARCHAR(50) NULL, 
    [rocnik] INT NULL, 
    [studijni_program] VARCHAR(50) NULL, 
    [akademicky_rok] INT NULL, 
    [kapacita_krouzku] INT NULL,
    [titul] VARCHAR(10) NULL, 
    [jazyk] VARCHAR(20) NULL
    
Studenti
	  [Id] INT NOT NULL PRIMARY KEY,
	  [forma_studia_k_p] VARCHAR(2) NULL, 
    [studijni_obor] VARCHAR(50) NULL, 
    [rocnik] INT NULL, 
    [studijni_program] VARCHAR(50) NULL, 
    [akademicky_rok] INT NULL, 
    [zs_pocet_studentu] INT NULL,
	  [ls_pocet_studentu] INT NULL,
	  [titul] VARCHAR(10) NULL


