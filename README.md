 # Azure Api Management Backend Web Api Example
I use this example as a poc to demonstrate jwt token validation for Azure Api Management

This repository contains:
<ul>
<li> A sample back end web api in .Net core 2.0 using OAuth 2.0 with Azure AD. </li>
<li> Arm template to deploy on an Azure Api App with necessary app settings. </li> 
<li> Arm template to import an api via a swagger to an Azure API Management Instance. The template adds also the imported api to the unlimited product (it exists by default in azure api management instance) with the jwt validation policy.  </li> 
</ul>
