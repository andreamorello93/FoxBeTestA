# FoxBeTestA
.Net Core &amp; EF Core

Il candidato realizzi una web api in .net core 6 che ricopra i requirements
dichiarati di seguito.
La repo del progetto deve risiedere su github, si consiglia di utilizzare la repo
dal inizio della realizzazione.
Al termine del progetto si invii ai referenti il link di accesso alla repo github e
se si reputi necessario una breve specifica di quanto realizzato.

### Requirement Funzionale:
Si realizzi un applicativo che permetta di anagrafare i dati essenziali di un
Hotel (Accommodation), le sue tipologie di stanze (Deluxe, Suite, Double,
Single) e il preziario.
Si Noti che il preziario è definito per RoomType, ovvero possono esistere
prezzi diversi per tipologia di stanza per il medesimo giorno.
I prezzi delle camere possono avere un rapporto di gerarchia ovvero ad
esempio:

“Il prezzo della Deluxe deve essere sempre il 30% in più rispetto alla camera
base (Single)”.

Il candidato è libero di ipotizzare e realizzare il requirement del prezzo
gerarchico.

L’applicativo deve permettere:

* L’ottenimento, la creazione, la modifica e la cancellazione dei dati
Accommodation
* L’ottenimento, la creazione, la modifica e la cancellazione dei dati
RoomType
* L’ottenimento, la creazione, la modifica e la cancellazione dei dati
PriceList

Key Point:
.net core 6
Entity Framework > 6.0.11
Code First
MediatR
Mssql
Docker

Requirement Tecnico:
* Il framework da usare è .net 6
* La web api può essere di tipo minimal api
* Si realizzi l’interfaccia api come CRUD
* Il layer di accesso db, entità e repository deve risiedere in un progetto
differente da quello di api
* Adottare la metodologia EF Code first per la generazione del modello db
* Applicare almeno due migrazioni al modello db
* Adottare il pattern MediatR per la segregazione del codice
* Il db da adottare è SqlServer 2022 (anche dockerizziata)
* Addizionale: Distribuire il tutto come Docker Compose
(minimo richiesto WebApi e Database
