# Let's Continue Our Safari Adventure

You are tasked with taking the Safari DB you created and putting that into an API. This API should use the simple Safari Database that we created. 


## Objectives
- Practice Creating Simple APIs
- Practice working with API Tools, such as POSTMAN (https://www.getpostman.com/)

## Requirements
- Using Ruby on Rails or ASP.NET create a simple API for you Safari Database
- Use your language's naming conventions, scaffolding and best practices where appropriate. 

**TIP**: It might be easier to delete the database in Postgres, and recreate it using the new project. 

### Explorer Mode

* [ ] Create the following endpoints: 
    - [x] Create `GET /Animals` Endpoint that returns all animals you have seen
    - [ ] Create `GET /Search?species=lion` that returns all animals where the species name contains the title parameter
    - [x] Create a `POST /Animal` endpoints that adds an animal to the database. This should take a JSON body
    - [ ] Create a `GET /Animal/{location}` that returns animals of only that location
    - [X] Create a `PUT /Animal/{animal}` endpoint that adds 1 to that animal
    - [X] Create a `DELETE /Animal/{animal}` endpoint that deletes that animal from the database
 
### Adventure Mode
- [ ] Normalize your database to have `Location` be its own table
- [ ] Extend your `Search` endpoint to search by animal or by location
- [ ] Create a `PUT /Animal/{animal}/{amount}` endpoint that adds `{amount}` to that animal


### Epic Mode
- [ ] Create a React or Vue app that talks to your API and Interacts with all the endpoints


## Additional Resources

### .NET 
