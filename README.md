# Azure Api Management Backend Web Api Example
I use this example as a poc to demonstrate jwt token validation for Azure Api Management

This repository contains:
<ul>
<li> A sample back end web api in .Net core 2.0 using OAuth 2.0 with Azure AD. </li>
 </ul>
 <ul>
<li> Arm template to deploy on an Azure Api App with necessary app settings. Template parameters: </li> 

| Name   | Description    |
|:--- |:---|
| apiAppName | The name of the azure api app |
| appServicePlanName | The name of the azure app service plan   |
| Domain| The name of the Azure Active Directory, the tenant |
| TenantId| The Id of the Azure Active Directory, the tenant id |
| Audience| The Uri of the service principal, Azure AD Application, created in Azure AD |
</ul>
<ul>
<li> Arm template to import an api via a swagger to an Azure API Management Instance. The template adds also the imported api to the unlimited product (it exists by default in azure api management instance) with the jwt validation policy.  Template parameters: </li> 
 
| Name   | Description    |
|:--- |:---|
| apimServiceName | The name of the existing Azure Api Management Instance |
| apiName | The name of the api in Azure Api Management   |
| serviceUrl| The url of the backend api (in our case the url of the Azure Api App that has been created with the webapp template) |
| swaggerUrl| The url of the swagger of the backend api  |
| suffix| The suffix that will be added to the Azure Api Manegement Gateway Url (contoso.azure-api.net/suffix) |
| policyContent| The policy of the api which is used for jwt validation |
| productName| The name of the product exising in Azure Api Management that the imported api will be added |

</ul>
