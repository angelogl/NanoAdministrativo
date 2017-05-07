-- Table: "Facturacion"."Usuarios"

-- DROP TABLE "Facturacion"."Usuarios";

CREATE TABLE "Facturacion"."Usuarios"
(
    "usrId" integer NOT NULL DEFAULT nextval('"Facturacion"."Usuarios_usrId_seq"'::regclass),
    "usrUsuario" character varying(25) COLLATE pg_catalog."default",
    "usrClave" character varying(25) COLLATE pg_catalog."default"
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE "Facturacion"."Usuarios"
    OWNER to postgres;

-- Table: "Facturacion"."Departamentos"

-- DROP TABLE "Facturacion"."Departamentos";

CREATE TABLE "Facturacion"."Departamentos"
(
    "depId" smallint NOT NULL DEFAULT nextval('"Facturacion"."Departamentos_depId_seq"'::regclass),
    "depCodigo" character varying(4) COLLATE pg_catalog."default",
    "depDescripcion" character varying(100) COLLATE pg_catalog."default",
    CONSTRAINT "Departamentos_pkey" PRIMARY KEY ("depId")
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE "Facturacion"."Departamentos"
    OWNER to postgres;