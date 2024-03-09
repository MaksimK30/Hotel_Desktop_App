using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HotelDesktop.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "accounts_id_seq");

            migrationBuilder.CreateSequence(
                name: "accounts_transactions_id_seq");

            migrationBuilder.CreateSequence(
                name: "bank_cards_id_seq");

            migrationBuilder.CreateSequence(
                name: "banks_id_seq");

            migrationBuilder.CreateSequence(
                name: "cash_desks_id_seq");

            migrationBuilder.CreateSequence(
                name: "departments_id_seq");

            migrationBuilder.CreateSequence(
                name: "employees_id_seq");

            migrationBuilder.CreateSequence(
                name: "genders_id_seq");

            migrationBuilder.CreateSequence(
                name: "guests_id_seq");

            migrationBuilder.CreateSequence(
                name: "inns_id_seq");

            migrationBuilder.CreateSequence(
                name: "messages_id_seq");

            migrationBuilder.CreateSequence(
                name: "passport_issuers_id_seq");

            migrationBuilder.CreateSequence(
                name: "passports_id_seq");

            migrationBuilder.CreateSequence(
                name: "payment_systems_id_seq");

            migrationBuilder.CreateSequence(
                name: "positions_id_seq");

            migrationBuilder.CreateSequence(
                name: "reservations_guests_id_seq");

            migrationBuilder.CreateSequence(
                name: "reservations_id_seq");

            migrationBuilder.CreateSequence(
                name: "role_places_id_seq");

            migrationBuilder.CreateSequence(
                name: "roles_id_seq");

            migrationBuilder.CreateSequence(
                name: "rooms_id_seq");

            migrationBuilder.CreateSequence(
                name: "rooms_photos_id_seq");

            migrationBuilder.CreateSequence(
                name: "roomtypes_id_seq");

            migrationBuilder.CreateSequence(
                name: "services_id_seq");

            migrationBuilder.CreateSequence(
                name: "snilses_id_seq");

            migrationBuilder.CreateSequence(
                name: "tariffs_id_seq");

            migrationBuilder.CreateSequence(
                name: "taxes_id_seq");

            migrationBuilder.CreateSequence(
                name: "transactions_id_seq");

            migrationBuilder.CreateSequence(
                name: "user_jwt_id_seq");

            migrationBuilder.CreateSequence(
                name: "users_id_seq");

            migrationBuilder.CreateSequence(
                name: "users_roles_id_seq");

            migrationBuilder.CreateTable(
                name: "banks",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "character varying", nullable: false),
                    registration_number = table.Column<string>(type: "character varying", nullable: false),
                    bik = table.Column<string>(type: "character varying", nullable: false),
                    ogrn = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("banks_pkey", x => x.id);
                },
                comment: "Информация о банках");

            migrationBuilder.CreateTable(
                name: "cash_desks",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    number = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("cash_desks_pkey", x => x.id);
                },
                comment: "Информация о кассах");

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("departments_pkey", x => x.id);
                },
                comment: "Подразделения предприятия");

            migrationBuilder.CreateTable(
                name: "genders",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("genders_pkey", x => x.id);
                },
                comment: "Определения полов пользователей");

            migrationBuilder.CreateTable(
                name: "inns",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    number = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false),
                    get_date = table.Column<DateOnly>(type: "date", nullable: false),
                    lastname = table.Column<string>(type: "character varying", nullable: false),
                    name = table.Column<string>(type: "character varying", nullable: false),
                    patronymic = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("inns_pkey", x => x.id);
                },
                comment: "Записи о документах ИНН пользователей");

            migrationBuilder.CreateTable(
                name: "passport_issuers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("passport_issuers_pkey", x => x.id);
                },
                comment: "Отделения выдачи паспортов");

            migrationBuilder.CreateTable(
                name: "payment_systems",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("payment_systems_pkey", x => x.id);
                },
                comment: "Платёжные системы");

            migrationBuilder.CreateTable(
                name: "role_places",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "character varying", nullable: false),
                    image = table.Column<byte[]>(type: "bytea", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("role_places_pk", x => x.id);
                },
                comment: "Опиасния ролевых мест пользователей");

            migrationBuilder.CreateTable(
                name: "room_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('roomtypes_id_seq'::regclass)"),
                    title = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("room_types_pkey", x => x.id);
                },
                comment: "Информация о типах номеров");

            migrationBuilder.CreateTable(
                name: "services",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "character varying", nullable: false),
                    description = table.Column<string>(type: "character varying", nullable: false),
                    cost = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("services_pkey", x => x.id);
                },
                comment: "Ифнормация об услугах отеля");

            migrationBuilder.CreateTable(
                name: "snilses",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    number = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false),
                    lastname = table.Column<string>(type: "character varying", nullable: false),
                    name = table.Column<string>(type: "character varying", nullable: false),
                    patronymic = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("snilses_pkey", x => x.id);
                },
                comment: "СНИЛСы пользователей");

            migrationBuilder.CreateTable(
                name: "tariffs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cost = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false),
                    breakfast = table.Column<bool>(type: "boolean", nullable: false),
                    lunch = table.Column<bool>(type: "boolean", nullable: false),
                    dinner = table.Column<bool>(type: "boolean", nullable: false),
                    title = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("tariffs_pkey", x => x.id);
                },
                comment: "Тарифы на аренду номеров");

            migrationBuilder.CreateTable(
                name: "taxes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "character varying", nullable: false),
                    description = table.Column<string>(type: "character varying", nullable: false),
                    rate = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("taxes_pkey", x => x.id);
                },
                comment: "Информация о налогах на финансовые транзакции");

            migrationBuilder.CreateTable(
                name: "positions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "character varying", nullable: false),
                    department_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("positions_pkey", x => x.id);
                    table.ForeignKey(
                        name: "positions_department_id_fkey",
                        column: x => x.department_id,
                        principalTable: "departments",
                        principalColumn: "id");
                },
                comment: "Должности");

            migrationBuilder.CreateTable(
                name: "passports",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    issue_date = table.Column<DateOnly>(type: "date", nullable: false),
                    issuer_id = table.Column<int>(type: "integer", nullable: false),
                    unit_code = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false),
                    series = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: false),
                    number = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: false),
                    lastname = table.Column<string>(type: "character varying", nullable: false),
                    name = table.Column<string>(type: "character varying", nullable: false),
                    patronymic = table.Column<string>(type: "character varying", nullable: false),
                    gender_id = table.Column<int>(type: "integer", nullable: false),
                    birthday = table.Column<DateOnly>(type: "date", nullable: false),
                    birthlocation = table.Column<string>(type: "character varying", nullable: false),
                    photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    previous_passport_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("passports_pkey", x => x.id);
                    table.ForeignKey(
                        name: "passports_gender_id_fkey",
                        column: x => x.gender_id,
                        principalTable: "genders",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "passports_issuer_id_fkey",
                        column: x => x.issuer_id,
                        principalTable: "passport_issuers",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "passports_previous_passport_id_fkey",
                        column: x => x.previous_passport_id,
                        principalTable: "passports",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    number = table.Column<string>(type: "character varying", nullable: false),
                    floor = table.Column<int>(type: "integer", nullable: false),
                    room_type_id = table.Column<int>(type: "integer", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false),
                    rooms = table.Column<int>(type: "integer", nullable: false),
                    minibar = table.Column<bool>(type: "boolean", nullable: false),
                    jacuzzi = table.Column<bool>(type: "boolean", nullable: false),
                    cost = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("rooms_pkey", x => x.id);
                    table.ForeignKey(
                        name: "rooms_room_type_id_fkey",
                        column: x => x.room_type_id,
                        principalTable: "room_types",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "transactions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date = table.Column<DateOnly>(type: "date", nullable: false),
                    description = table.Column<string>(type: "character varying", nullable: false),
                    tax_id = table.Column<int>(type: "integer", nullable: false),
                    cash_desk_id = table.Column<int>(type: "integer", nullable: false),
                    service_id = table.Column<int>(type: "integer", nullable: false),
                    service_count = table.Column<decimal>(type: "numeric(3,2)", precision: 3, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("transactions_pkey", x => x.id);
                    table.ForeignKey(
                        name: "transactions_cash_desk_id_fkey",
                        column: x => x.cash_desk_id,
                        principalTable: "cash_desks",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "transactions_service_id_fkey",
                        column: x => x.service_id,
                        principalTable: "services",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "transactions_tax_id_fkey",
                        column: x => x.tax_id,
                        principalTable: "taxes",
                        principalColumn: "id");
                },
                comment: "Информация о финансовых транзакциях");

            migrationBuilder.CreateTable(
                name: "role_places_positions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    position_id = table.Column<int>(type: "integer", nullable: false),
                    role_place_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("newtable_pk", x => x.id);
                    table.ForeignKey(
                        name: "role_places_positions_fk",
                        column: x => x.position_id,
                        principalTable: "positions",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "role_places_positions_fk_1",
                        column: x => x.role_place_id,
                        principalTable: "role_places",
                        principalColumn: "id");
                },
                comment: "Информация о том, какие ролевые места доступны различным пользователйм в зависимости от от должности");

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    passport_id = table.Column<int>(type: "integer", nullable: false),
                    snils_id = table.Column<int>(type: "integer", nullable: false),
                    inn_id = table.Column<int>(type: "integer", nullable: false),
                    email = table.Column<string>(type: "character varying", nullable: false),
                    phone = table.Column<string>(type: "character varying(12)", maxLength: 12, nullable: false),
                    login = table.Column<string>(type: "character varying", nullable: false),
                    password = table.Column<string>(type: "character varying", nullable: false),
                    position = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("users_pkey", x => x.id);
                    table.ForeignKey(
                        name: "users_fk",
                        column: x => x.id,
                        principalTable: "positions",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "users_inn_id_fkey",
                        column: x => x.inn_id,
                        principalTable: "inns",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "users_passport_id_fkey",
                        column: x => x.passport_id,
                        principalTable: "passports",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "users_snils_id_fkey",
                        column: x => x.snils_id,
                        principalTable: "snilses",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "rooms_photo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('rooms_photos_id_seq'::regclass)"),
                    room_id = table.Column<int>(type: "integer", nullable: false),
                    photo = table.Column<byte[]>(type: "bytea", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("rooms_photo_pkey", x => x.id);
                    table.ForeignKey(
                        name: "rooms_photo_room_id_fkey",
                        column: x => x.room_id,
                        principalTable: "rooms",
                        principalColumn: "id");
                },
                comment: "Фотографии номеров");

            migrationBuilder.CreateTable(
                name: "bank_cards",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    number = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    owner = table.Column<string>(type: "character varying", nullable: false),
                    expired_date = table.Column<DateOnly>(type: "date", nullable: false),
                    payment_system_id = table.Column<int>(type: "integer", nullable: false),
                    bank_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("bank_cards_pkey", x => x.id);
                    table.ForeignKey(
                        name: "bank_cards_bank_id_fkey",
                        column: x => x.bank_id,
                        principalTable: "banks",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "bank_cards_payment_system_id_fkey",
                        column: x => x.payment_system_id,
                        principalTable: "payment_systems",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "bank_cards_user_id_fkey",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id");
                },
                comment: "Информация о банковских карточках пользователей");

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    hire_date = table.Column<DateOnly>(type: "date", nullable: false),
                    fire_date = table.Column<DateOnly>(type: "date", nullable: false),
                    is_fired = table.Column<bool>(type: "boolean", nullable: false),
                    position_id = table.Column<int>(type: "integer", nullable: false),
                    salary = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("employees_pkey", x => x.id);
                    table.ForeignKey(
                        name: "employees_position_id_fkey",
                        column: x => x.position_id,
                        principalTable: "positions",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "employees_user_id_fkey",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id");
                },
                comment: "Сотрудники предприятия");

            migrationBuilder.CreateTable(
                name: "messages",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    send_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    from = table.Column<int>(type: "integer", nullable: false),
                    to = table.Column<int>(type: "integer", nullable: false),
                    is_readed = table.Column<bool>(type: "boolean", nullable: false),
                    theme = table.Column<string>(type: "character varying", nullable: false),
                    message_text = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("messages_pkey", x => x.id);
                    table.ForeignKey(
                        name: "messages_from_fkey",
                        column: x => x.from,
                        principalTable: "users",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "messages_to_fkey",
                        column: x => x.to,
                        principalTable: "users",
                        principalColumn: "id");
                },
                comment: "Сообщения пользователей");

            migrationBuilder.CreateTable(
                name: "user_jwt",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('users_id_seq'::regclass)"),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    refresh_token = table.Column<string>(type: "character varying", nullable: false),
                    device = table.Column<string>(type: "character varying", nullable: false),
                    ip = table.Column<string>(type: "character varying", nullable: false),
                    address = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("user_jwt_pkey", x => x.id);
                    table.ForeignKey(
                        name: "user_jwt_user_id_fkey",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id");
                },
                comment: "Информация о выданных токенах доступа");

            migrationBuilder.CreateTable(
                name: "accounts",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    bank_card_id = table.Column<int>(type: "integer", nullable: false),
                    is_blocked = table.Column<bool>(type: "boolean", nullable: false),
                    block_reason = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("accounts_pkey", x => x.id);
                    table.ForeignKey(
                        name: "accounts_bank_card_id_fkey",
                        column: x => x.bank_card_id,
                        principalTable: "bank_cards",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "accounts_user_id_fkey",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id");
                },
                comment: "Информация о счетах пользователей");

            migrationBuilder.CreateTable(
                name: "accounts_transactions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    account_id = table.Column<int>(type: "integer", nullable: false),
                    transaction_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("accounts_transactions_pkey", x => x.id);
                    table.ForeignKey(
                        name: "accounts_transactions_account_id_fkey",
                        column: x => x.account_id,
                        principalTable: "accounts",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "accounts_transactions_transaction_id_fkey",
                        column: x => x.transaction_id,
                        principalTable: "transactions",
                        principalColumn: "id");
                },
                comment: "Транзакции и аккаунты, к которым они привязаны");

            migrationBuilder.CreateTable(
                name: "guests",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    account_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("guests_pkey", x => x.id);
                    table.ForeignKey(
                        name: "guests_account_id_fkey",
                        column: x => x.account_id,
                        principalTable: "accounts",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "guests_user_id_fkey",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id");
                },
                comment: "Информация о гостях");

            migrationBuilder.CreateTable(
                name: "reservations",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    start_date = table.Column<DateOnly>(type: "date", nullable: false),
                    end_date = table.Column<DateOnly>(type: "date", nullable: false),
                    main_guest_id = table.Column<int>(type: "integer", nullable: false),
                    contact_phone = table.Column<string>(type: "character varying(12)", maxLength: 12, nullable: false),
                    contact_gender_id = table.Column<int>(type: "integer", nullable: false),
                    contact_name = table.Column<string>(type: "character varying", nullable: false),
                    account_id = table.Column<int>(type: "integer", nullable: false),
                    childrens = table.Column<int>(type: "integer", nullable: false),
                    adults = table.Column<int>(type: "integer", nullable: false),
                    tariff_id = table.Column<int>(type: "integer", nullable: false),
                    service_count = table.Column<decimal>(type: "numeric(3,2)", precision: 3, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("reservations_pkey", x => x.id);
                    table.ForeignKey(
                        name: "reservations_account_id_fkey",
                        column: x => x.account_id,
                        principalTable: "accounts",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "reservations_contact_gender_id_fkey",
                        column: x => x.contact_gender_id,
                        principalTable: "genders",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "reservations_main_guest_id_fkey",
                        column: x => x.main_guest_id,
                        principalTable: "guests",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "reservations_tariff_id_fkey",
                        column: x => x.tariff_id,
                        principalTable: "tariffs",
                        principalColumn: "id");
                },
                comment: "Информация о бронировании");

            migrationBuilder.CreateTable(
                name: "reservations_guests",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    guest_id = table.Column<int>(type: "integer", nullable: false),
                    reservation_id = table.Column<int>(type: "integer", nullable: false),
                    is_child = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("reservations_guests_pkey", x => x.id);
                    table.ForeignKey(
                        name: "reservations_guests_guest_id_fkey",
                        column: x => x.guest_id,
                        principalTable: "guests",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "reservations_guests_reservation_id_fkey",
                        column: x => x.reservation_id,
                        principalTable: "reservations",
                        principalColumn: "id");
                },
                comment: "Информация о бронированиях и связанных с ними гостях");

            migrationBuilder.CreateIndex(
                name: "IX_accounts_bank_card_id",
                table: "accounts",
                column: "bank_card_id");

            migrationBuilder.CreateIndex(
                name: "IX_accounts_user_id",
                table: "accounts",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_accounts_transactions_account_id",
                table: "accounts_transactions",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "IX_accounts_transactions_transaction_id",
                table: "accounts_transactions",
                column: "transaction_id");

            migrationBuilder.CreateIndex(
                name: "IX_bank_cards_bank_id",
                table: "bank_cards",
                column: "bank_id");

            migrationBuilder.CreateIndex(
                name: "IX_bank_cards_payment_system_id",
                table: "bank_cards",
                column: "payment_system_id");

            migrationBuilder.CreateIndex(
                name: "IX_bank_cards_user_id",
                table: "bank_cards",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "banks_bik_key",
                table: "banks",
                column: "bik",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "banks_ogrn_key",
                table: "banks",
                column: "ogrn",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "banks_registration_number_key",
                table: "banks",
                column: "registration_number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "banks_title_key",
                table: "banks",
                column: "title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "cash_desks_number_key",
                table: "cash_desks",
                column: "number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "departments_title_key",
                table: "departments",
                column: "title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_employees_position_id",
                table: "employees",
                column: "position_id");

            migrationBuilder.CreateIndex(
                name: "IX_employees_user_id",
                table: "employees",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "genders_title_key",
                table: "genders",
                column: "title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_guests_account_id",
                table: "guests",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "IX_guests_user_id",
                table: "guests",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "inns_number_key",
                table: "inns",
                column: "number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_messages_from",
                table: "messages",
                column: "from");

            migrationBuilder.CreateIndex(
                name: "IX_messages_to",
                table: "messages",
                column: "to");

            migrationBuilder.CreateIndex(
                name: "passport_issuers_title_key",
                table: "passport_issuers",
                column: "title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_passports_gender_id",
                table: "passports",
                column: "gender_id");

            migrationBuilder.CreateIndex(
                name: "IX_passports_issuer_id",
                table: "passports",
                column: "issuer_id");

            migrationBuilder.CreateIndex(
                name: "IX_passports_previous_passport_id",
                table: "passports",
                column: "previous_passport_id");

            migrationBuilder.CreateIndex(
                name: "passports_series_number_key",
                table: "passports",
                columns: new[] { "series", "number" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "payment_systems_title_key",
                table: "payment_systems",
                column: "title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_positions_department_id",
                table: "positions",
                column: "department_id");

            migrationBuilder.CreateIndex(
                name: "positions_title_key",
                table: "positions",
                column: "title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_reservations_account_id",
                table: "reservations",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "IX_reservations_contact_gender_id",
                table: "reservations",
                column: "contact_gender_id");

            migrationBuilder.CreateIndex(
                name: "IX_reservations_main_guest_id",
                table: "reservations",
                column: "main_guest_id");

            migrationBuilder.CreateIndex(
                name: "IX_reservations_tariff_id",
                table: "reservations",
                column: "tariff_id");

            migrationBuilder.CreateIndex(
                name: "IX_reservations_guests_guest_id",
                table: "reservations_guests",
                column: "guest_id");

            migrationBuilder.CreateIndex(
                name: "IX_reservations_guests_reservation_id",
                table: "reservations_guests",
                column: "reservation_id");

            migrationBuilder.CreateIndex(
                name: "role_places_un",
                table: "role_places",
                column: "title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_role_places_positions_position_id",
                table: "role_places_positions",
                column: "position_id");

            migrationBuilder.CreateIndex(
                name: "IX_role_places_positions_role_place_id",
                table: "role_places_positions",
                column: "role_place_id");

            migrationBuilder.CreateIndex(
                name: "room_types_title_key",
                table: "room_types",
                column: "title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_rooms_room_type_id",
                table: "rooms",
                column: "room_type_id");

            migrationBuilder.CreateIndex(
                name: "rooms_number_key",
                table: "rooms",
                column: "number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_rooms_photo_room_id",
                table: "rooms_photo",
                column: "room_id");

            migrationBuilder.CreateIndex(
                name: "services_title_key",
                table: "services",
                column: "title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "snilses_number_key",
                table: "snilses",
                column: "number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "tariffs_title_key",
                table: "tariffs",
                column: "title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "taxes_title_key",
                table: "taxes",
                column: "title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_transactions_cash_desk_id",
                table: "transactions",
                column: "cash_desk_id");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_service_id",
                table: "transactions",
                column: "service_id");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_tax_id",
                table: "transactions",
                column: "tax_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_jwt_user_id",
                table: "user_jwt",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_users_inn_id",
                table: "users",
                column: "inn_id");

            migrationBuilder.CreateIndex(
                name: "IX_users_passport_id",
                table: "users",
                column: "passport_id");

            migrationBuilder.CreateIndex(
                name: "IX_users_snils_id",
                table: "users",
                column: "snils_id");

            migrationBuilder.CreateIndex(
                name: "users_email_key",
                table: "users",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "users_login_key",
                table: "users",
                column: "login",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accounts_transactions");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "messages");

            migrationBuilder.DropTable(
                name: "reservations_guests");

            migrationBuilder.DropTable(
                name: "role_places_positions");

            migrationBuilder.DropTable(
                name: "rooms_photo");

            migrationBuilder.DropTable(
                name: "user_jwt");

            migrationBuilder.DropTable(
                name: "transactions");

            migrationBuilder.DropTable(
                name: "reservations");

            migrationBuilder.DropTable(
                name: "role_places");

            migrationBuilder.DropTable(
                name: "rooms");

            migrationBuilder.DropTable(
                name: "cash_desks");

            migrationBuilder.DropTable(
                name: "services");

            migrationBuilder.DropTable(
                name: "taxes");

            migrationBuilder.DropTable(
                name: "guests");

            migrationBuilder.DropTable(
                name: "tariffs");

            migrationBuilder.DropTable(
                name: "room_types");

            migrationBuilder.DropTable(
                name: "accounts");

            migrationBuilder.DropTable(
                name: "bank_cards");

            migrationBuilder.DropTable(
                name: "banks");

            migrationBuilder.DropTable(
                name: "payment_systems");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "positions");

            migrationBuilder.DropTable(
                name: "inns");

            migrationBuilder.DropTable(
                name: "passports");

            migrationBuilder.DropTable(
                name: "snilses");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropTable(
                name: "genders");

            migrationBuilder.DropTable(
                name: "passport_issuers");

            migrationBuilder.DropSequence(
                name: "accounts_id_seq");

            migrationBuilder.DropSequence(
                name: "accounts_transactions_id_seq");

            migrationBuilder.DropSequence(
                name: "bank_cards_id_seq");

            migrationBuilder.DropSequence(
                name: "banks_id_seq");

            migrationBuilder.DropSequence(
                name: "cash_desks_id_seq");

            migrationBuilder.DropSequence(
                name: "departments_id_seq");

            migrationBuilder.DropSequence(
                name: "employees_id_seq");

            migrationBuilder.DropSequence(
                name: "genders_id_seq");

            migrationBuilder.DropSequence(
                name: "guests_id_seq");

            migrationBuilder.DropSequence(
                name: "inns_id_seq");

            migrationBuilder.DropSequence(
                name: "messages_id_seq");

            migrationBuilder.DropSequence(
                name: "passport_issuers_id_seq");

            migrationBuilder.DropSequence(
                name: "passports_id_seq");

            migrationBuilder.DropSequence(
                name: "payment_systems_id_seq");

            migrationBuilder.DropSequence(
                name: "positions_id_seq");

            migrationBuilder.DropSequence(
                name: "reservations_guests_id_seq");

            migrationBuilder.DropSequence(
                name: "reservations_id_seq");

            migrationBuilder.DropSequence(
                name: "role_places_id_seq");

            migrationBuilder.DropSequence(
                name: "roles_id_seq");

            migrationBuilder.DropSequence(
                name: "rooms_id_seq");

            migrationBuilder.DropSequence(
                name: "rooms_photos_id_seq");

            migrationBuilder.DropSequence(
                name: "roomtypes_id_seq");

            migrationBuilder.DropSequence(
                name: "services_id_seq");

            migrationBuilder.DropSequence(
                name: "snilses_id_seq");

            migrationBuilder.DropSequence(
                name: "tariffs_id_seq");

            migrationBuilder.DropSequence(
                name: "taxes_id_seq");

            migrationBuilder.DropSequence(
                name: "transactions_id_seq");

            migrationBuilder.DropSequence(
                name: "user_jwt_id_seq");

            migrationBuilder.DropSequence(
                name: "users_id_seq");

            migrationBuilder.DropSequence(
                name: "users_roles_id_seq");
        }
    }
}
