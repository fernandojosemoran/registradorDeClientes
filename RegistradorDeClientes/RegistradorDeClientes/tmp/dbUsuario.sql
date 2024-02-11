Use Registro
Go
CREATE Table AtenticacionUsuario(
    Id Int PRIMARY KEY IDENTITY(1,1),
    Codigo UNIQUEIDENTIFIER,
    Nombre VARCHAR(50) NOT NULL,
    Email VARCHAR(20) NOT NULL UNIQUE,
    Contrasena VARCHAR(100) NOT NULL,
    Roll VARCHAR(50) NOT NULL,
    CreateAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    UpdateAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

Go 

INSERT INTO AtenticacionUsuario(
    Codigo,
    Nombre,
    Email,
    Contrasena,
    Roll
) VALUES (
    NEWID(),
    'Fernando',
    'fernando@gmail.com',
    'C#',
    'Empleado'
);
