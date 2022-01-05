START TRANSACTION;


DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20220105174132_Initial_Data_WithJsonB2') THEN
    INSERT INTO "Documents" ("Id", "Name", "Created", "DataJsonb")
    VALUES ('f6eed1c9-8ed9-4589-925a-e2b1da46430b', 'Jsonb File', TIMESTAMPTZ '2022-01-05 17:46:38.7528Z', ' {"score" : 100,"person": {"first_name":"Tom","last_name":"Cruz"}}');
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20220105174132_Initial_Data_WithJsonB2') THEN
    INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
    VALUES ('20220105174132_Initial_Data_WithJsonB2', '6.0.1');
    END IF;
END $EF$;
COMMIT;

