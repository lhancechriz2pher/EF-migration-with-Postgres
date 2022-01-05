START TRANSACTION;


DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20220105171343_Initial_Data_WithJsonB') THEN
    INSERT INTO "Documents" ("Id", "Name", "Created", "DataJsonb")
    VALUES ('2321d335-ca88-438f-9e0d-a8f4d463f296', 'Jsonb File', TIMESTAMPTZ '2022-01-05 17:31:34.613452Z', ' {"score" : 100}');
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20220105171343_Initial_Data_WithJsonB') THEN
    INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
    VALUES ('20220105171343_Initial_Data_WithJsonB', '6.0.1');
    END IF;
END $EF$;
COMMIT;

