# Getting started

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (AWSECommerceService.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=AWSECommerceService-CSharp&workspaceName=AWSECommerceService&projectName=AWSECommerceService.Standard)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the AWSECommerceService library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=AWSECommerceService-CSharp&workspaceName=AWSECommerceService&projectName=AWSECommerceService.Standard)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=AWSECommerceService-CSharp&workspaceName=AWSECommerceService&projectName=AWSECommerceService.Standard)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=AWSECommerceService-CSharp&workspaceName=AWSECommerceService&projectName=AWSECommerceService.Standard)

### 3. Add reference of the library project

In order to use the AWSECommerceService library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=AWSECommerceService-CSharp&workspaceName=AWSECommerceService&projectName=AWSECommerceService.Standard)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` AWSECommerceService.Standard ``` and click ``` OK ```. By doing this, we have added a reference of the ```AWSECommerceService.Standard``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=AWSECommerceService-CSharp&workspaceName=AWSECommerceService&projectName=AWSECommerceService.Standard)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=AWSECommerceService-CSharp&workspaceName=AWSECommerceService&projectName=AWSECommerceService.Standard)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### 

API client can be initialized as following.

```csharp

AWSECommerceServiceClient client = new AWSECommerceServiceClient();
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [AWSECommerceServiceBindingController](#awse_commerce_service_binding_controller)

## <a name="awse_commerce_service_binding_controller"></a>![Class: ](https://apidocs.io/img/class.png "AWSECommerceService.Standard.Controllers.AWSECommerceServiceBindingController") AWSECommerceServiceBindingController

### Get singleton instance

The singleton instance of the ``` AWSECommerceServiceBindingController ``` class can be accessed from the API Client.

```csharp
AWSECommerceServiceBindingController aWSECommerceServiceBinding = client.AWSECommerceServiceBinding;
```

### <a name="create_item_search_post11"></a>![Method: ](https://apidocs.io/img/method.png "AWSECommerceService.Standard.Controllers.AWSECommerceServiceBindingController.CreateItemSearchPost11") CreateItemSearchPost11

> *Tags:*  ``` Skips Authentication ``` 

> ItemSearch90


```csharp
Task<Models.ItemSearchResponseMsg> CreateItemSearchPost11(Models.ItemSearchRequestMsg body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new Models.ItemSearchRequestMsg();

Models.ItemSearchResponseMsg result = await aWSECommerceServiceBinding.CreateItemSearchPost11(body);

```


### <a name="create_item_lookup_post11"></a>![Method: ](https://apidocs.io/img/method.png "AWSECommerceService.Standard.Controllers.AWSECommerceServiceBindingController.CreateItemLookupPost11") CreateItemLookupPost11

> *Tags:*  ``` Skips Authentication ``` 

> ItemLookup91


```csharp
Task<Models.ItemLookupResponseMsg> CreateItemLookupPost11(Models.ItemLookupRequestMsg body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new Models.ItemLookupRequestMsg();

Models.ItemLookupResponseMsg result = await aWSECommerceServiceBinding.CreateItemLookupPost11(body);

```


### <a name="create_browse_node_lookup_post11"></a>![Method: ](https://apidocs.io/img/method.png "AWSECommerceService.Standard.Controllers.AWSECommerceServiceBindingController.CreateBrowseNodeLookupPost11") CreateBrowseNodeLookupPost11

> *Tags:*  ``` Skips Authentication ``` 

> BrowseNodeLookup92


```csharp
Task<Models.BrowseNodeLookupResponseMsg> CreateBrowseNodeLookupPost11(Models.BrowseNodeLookupRequestMsg body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new Models.BrowseNodeLookupRequestMsg();

Models.BrowseNodeLookupResponseMsg result = await aWSECommerceServiceBinding.CreateBrowseNodeLookupPost11(body);

```


### <a name="create_similarity_lookup_post11"></a>![Method: ](https://apidocs.io/img/method.png "AWSECommerceService.Standard.Controllers.AWSECommerceServiceBindingController.CreateSimilarityLookupPost11") CreateSimilarityLookupPost11

> *Tags:*  ``` Skips Authentication ``` 

> SimilarityLookup93


```csharp
Task<Models.SimilarityLookupResponseMsg> CreateSimilarityLookupPost11(Models.SimilarityLookupRequestMsg body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new Models.SimilarityLookupRequestMsg();

Models.SimilarityLookupResponseMsg result = await aWSECommerceServiceBinding.CreateSimilarityLookupPost11(body);

```


### <a name="create_cart_get_post11"></a>![Method: ](https://apidocs.io/img/method.png "AWSECommerceService.Standard.Controllers.AWSECommerceServiceBindingController.CreateCartGetPost11") CreateCartGetPost11

> *Tags:*  ``` Skips Authentication ``` 

> CartGet94


```csharp
Task<Models.CartGetResponseMsg> CreateCartGetPost11(Models.CartGetRequestMsg body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new Models.CartGetRequestMsg();

Models.CartGetResponseMsg result = await aWSECommerceServiceBinding.CreateCartGetPost11(body);

```


### <a name="create_cart_add_post11"></a>![Method: ](https://apidocs.io/img/method.png "AWSECommerceService.Standard.Controllers.AWSECommerceServiceBindingController.CreateCartAddPost11") CreateCartAddPost11

> *Tags:*  ``` Skips Authentication ``` 

> CartAdd95


```csharp
Task<Models.CartAddResponseMsg> CreateCartAddPost11(Models.CartAddRequestMsg body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new Models.CartAddRequestMsg();

Models.CartAddResponseMsg result = await aWSECommerceServiceBinding.CreateCartAddPost11(body);

```


### <a name="create_cart_create_post11"></a>![Method: ](https://apidocs.io/img/method.png "AWSECommerceService.Standard.Controllers.AWSECommerceServiceBindingController.CreateCartCreatePost11") CreateCartCreatePost11

> *Tags:*  ``` Skips Authentication ``` 

> CartCreate96


```csharp
Task<Models.CartCreateResponseMsg> CreateCartCreatePost11(Models.CartCreateRequestMsg body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new Models.CartCreateRequestMsg();

Models.CartCreateResponseMsg result = await aWSECommerceServiceBinding.CreateCartCreatePost11(body);

```


### <a name="create_cart_modify_post11"></a>![Method: ](https://apidocs.io/img/method.png "AWSECommerceService.Standard.Controllers.AWSECommerceServiceBindingController.CreateCartModifyPost11") CreateCartModifyPost11

> *Tags:*  ``` Skips Authentication ``` 

> CartModify97


```csharp
Task<Models.CartModifyResponseMsg> CreateCartModifyPost11(Models.CartModifyRequestMsg body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new Models.CartModifyRequestMsg();

Models.CartModifyResponseMsg result = await aWSECommerceServiceBinding.CreateCartModifyPost11(body);

```


### <a name="create_cart_clear_post11"></a>![Method: ](https://apidocs.io/img/method.png "AWSECommerceService.Standard.Controllers.AWSECommerceServiceBindingController.CreateCartClearPost11") CreateCartClearPost11

> *Tags:*  ``` Skips Authentication ``` 

> CartClear98


```csharp
Task<Models.CartClearResponseMsg> CreateCartClearPost11(Models.CartClearRequestMsg body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new Models.CartClearRequestMsg();

Models.CartClearResponseMsg result = await aWSECommerceServiceBinding.CreateCartClearPost11(body);

```


[Back to List of Controllers](#list_of_controllers)



