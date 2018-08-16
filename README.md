# FilteringAJAX-ViewCalls

Example for managing authorization for AJAX request or call views that require an Authorization.
https://filteringajaxcalls.azurewebsites.net

## Getting Started:

These instructions will give you the flow to understand the example.

## Steps:

### 1.Routing

In the RouteConfig.css redirects to

```
/Home/Index
```

But the *Index* method in the HomeController.cs has a decorator called *AuthorizeView*, this will give us the logic to valide if the page can be shown or not.

### 2.Types of Filters

In the folder *Filters* exists two classes

```
AuthorizeView.cs
AutorizarAJAXAttribute.cs
```

The AuthorizeView.cs inherits from *ActionFilterAttribute*. For futher information of the class visit, https://msdn.microsoft.com/es-es/library/system.web.mvc.actionfilterattribute(v=vs.100).aspx.

The AutorizarAJAXAttribute.cs inherits from *AuthorizeAttribute*. For futher information of the class visit, https://msdn.microsoft.com/es-es/library/system.web.mvc.authorizeattribute(v=vs.98).aspx.

With theses classes we can filter the request for a view or an AJAX according our needs. 

We just has to override the methods *OnActionExecuting* for *ActionFilterAttribute* class and *HandleUnauthorizedRequest* for *AuthorizeAttribute* class.

### 3.Flow

If we want to visit the route */Home/Index* the filter will execute the logics of *OnActionExecuting* and check if theres an active session, is there an active session, the flow works normally, but is the session is null so will redirect
