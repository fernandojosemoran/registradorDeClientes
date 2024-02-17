CREATE TABLE Cliente (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Code VARCHAR(50) NOT NULL UNIQUE, 
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(100) NOT NULL, 
    Email VARCHAR(50) NOT NULL UNIQUE,
    Telefono VARCHAR(12) NOT NULL UNIQUE,
    Direccion VARCHAR(120) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    Genero VARCHAR(10) NOT NULL,
    EstadoCivil VARCHAR(10) NOT NULL,
    FechaRegistro DATE NOT NULL,
    CreadoEn DATETIME DEFAULT GETDATE(),
    ActualizadoEn DATETIME DEFAULT GETDATE()
);

GO

INSERT INTO Cliente (Code, Nombre, Apellido, Email, Telefono, Direccion, FechaNacimiento, Genero, EstadoCivil, FechaRegistro)
VALUES
(NEWID(), 'Juan', 'Perez', 'juan@example.com', '1234567890', 'Calle 123', '1990-01-01', 'Masculino', 'Soltero', '2024-02-05'),
(NEWID(), 'Maria', 'Gonzalez', 'maria@example.com', '0987654321', 'Avenida 456', '1985-05-15', 'Femenino', 'Casado', '2024-02-05'),
(NEWID(), 'Pedro', 'Rodriguez', 'pedro@example.com', '9876543210', 'Carrera 789', '1978-09-20', 'Masculino', 'Divorciado', '2024-02-05'),
(NEWID(), 'Laura', 'Lopez', 'laura@example.com', '0123456789', 'Plaza 987', '2000-12-10', 'Femenino', 'Soltero', '2024-02-05'),
(NEWID(), 'Carlos', 'Martinez', 'carlos@example.com', '1112223333', 'Avenida 456', '1995-03-25', 'Masculino', 'Casado', '2024-02-05'),
(NEWID(), 'Ana', 'Sanchez', 'ana@example.com', '4445556666', 'Calle 789', '1982-07-18', 'Femenino', 'Soltero', '2024-02-05'),
(NEWID(), 'Diego', 'Hernandez', 'diego@example.com', '7778889999', 'Carrera 123', '1970-11-30', 'Masculino', 'Viudo', '2024-02-05'),
(NEWID(), 'Elena', 'Diaz', 'elena@example.com', '2223334444', 'Carrera 456', '1998-08-05', 'Femenino', 'Casado', '2024-02-05'),
(NEWID(), 'Alejandro', 'Gomez', 'alejandro@example.com', '5556667777', 'Calle 789', '1989-04-12', 'Masculino', 'Divorciado', '2024-02-05'),
(NEWID(), 'Sofia', 'Fernandez', 'sofia@example.com', '8889990000', 'Avenida 123', '1993-06-28', 'Femenino', 'Soltero', '2024-02-05');
