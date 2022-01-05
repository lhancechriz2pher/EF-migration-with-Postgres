START TRANSACTION;


DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20220105141731_Initial_Data') THEN
    INSERT INTO "Documents" ("Id", "Name", "Created")
    VALUES ('96b97699-6e74-4c24-a694-b25d102f0418', 'MSDN Magazine', TIMESTAMPTZ '2022-01-05 17:05:41.54361Z');
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20220105141731_Initial_Data') THEN
    INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
    VALUES ('20220105141731_Initial_Data', '6.0.1');
    END IF;
END $EF$;
COMMIT;

