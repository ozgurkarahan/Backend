# Azure Api Management Backend Web Api Example
I use this example as a poc to demonstrate jwt token validation for Azure Api Management

This repository contains:
<ul>
<li> A sample back end web api in .Net core using OAuth 2.0 with Azure AD. </li>
<li> Arm templates to deploy on an azure api app in Azure with necessary app settings. </li> 
<li> Arm template to import an api via a swagger to an Azure API Management Instance. The arm template add the api to the unlimited product (exist by default in azure api management instance) with the jwt validation policy.  </li> 
</ul>
