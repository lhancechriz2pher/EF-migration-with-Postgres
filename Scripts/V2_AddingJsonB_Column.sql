START TRANSACTION;


DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20220105062553_adding_jsonb_column') THEN
    ALTER TABLE "Documents" ADD "DataJsonb" jsonb NULL;
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20220105062553_adding_jsonb_column') THEN
    INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
    VALUES ('20220105062553_adding_jsonb_column', '6.0.1');
    END IF;
END $EF$;
COMMIT;

