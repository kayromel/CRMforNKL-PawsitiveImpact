# NoKillInventory-CapstoneF23

## Overview

The No Kill Louisville Inventory System is an ASP.NET Blazor web app that provides a simple system for No Kill Louisville to track their inventory.

## Requirements

- .NET 8 Runtime
- Docker and Docker Compose
- Tailscale VPN

## Setup

### .NET

To run the web app you will need to install the .NET 8 Runtime and the ASP.NET Core Runtime.

We recommend installing the Hosting Bundle under the "Run Server Apps" section, as it includes everything you will need.

You can find the runtime and hosting bundle [here](https://dotnet.microsoft.com/en-us/download/dotnet/8.0/runtime?cid=getdotnetcore&os=windows&arch=x64).

### EF Core

The steps to initialize and create the SQLite database are:
1. Open a terminal and cd to the `NoKill-Inventory/No-Kill-Inventory/` directory
2. Run the command `dotnet ef database update`
3. Wait for the command to finish, and verify the `app.db` file has been created in the `NoKill-Inventory/No-Kill-Inventory/No-Kill-Inventory/Data/` directory

### Docker

You will need Docker and Docker Compose installed on the machine that will be running the web app.

Follow the guides linked to install Docker and Docker Compose
1. [Docker](https://docs.docker.com/engine/install/) (If on Windows, Docker Desktop includes Compose)
2. [Docker Compose](https://docs.docker.com/compose/install/)
3. Once both have been installed, run the Docker Compose script in the project
   - Cd into `NoKill-Inventory/No-Kill-Inventory/`
   - Run the command `docker compose up`
4. The script will download any dependencies it needs, and then should start itself

### Tailscale

Tailscale will need to be installed on both the machine running the web app and any machine that will be accessing it.

A Tailscale account will need to be created so the Admin can register the host machine, and each user's machine and account on the Tailnet

Download Tailscale [here](https://tailscale.com/).

## Using The App

See the User's Manual or Programmer's Manual in the /Documents/Implementation/ folder.

## Additional Help

### Migrating The Database

If for any reason you need to move the web app and want to keep all the data in the current database use the steps below to migrate the data to a new database.

1. Download and install the pre-compiled binaries the host operating system [here](https://www.sqlite.org/download.html). (This is not neccesary to use the database with the app, only to migrate the data to a new one)
2. Open a terminal and cd to the /NoKill-Inventory/No-Kill-Inventory/No-Kill-Inventory/Data/ folder
3. Run the command `sqlite3 app.db .dump > dump_file.sql`
4. Wherever the new database is that you want to insert the data into, run this command `sqlite3 new_database_name.db < dump_file.sql`
