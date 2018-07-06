# dmr-webservice
DMR (Dansk Motor Register) Webservice (Scraper)

Scraperen henter data fra Motorregistret og pakker dem ind i et typestærkt retur-objekt.


## Installation
Installeres på IIS webserver eller lign server med .NET 4.7, som kan hoste et ASP.NET website.

## Brug
Åbn siden i browser og åbn **/Help** for at få hjælp om API'et

    /api/{nummerplade} giver oplysninger om køretøj

    /api/{nummerplade}/{dato} giver historiske oplysninger