CREATE TABLE [dbo].[Zamestnanci]
(
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
)

