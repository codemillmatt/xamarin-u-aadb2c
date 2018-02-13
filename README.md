# Azure AD B2C Crash Course

Find the slides [here](https://msou.co/bc0)

## Description

One seemingly simple requirement for an app is to allow users to create an account. But the scope of that requirement grows quickly: How do they sign in? Change passwords? Can they sign in with social accounts like Facebook? What about implementing 2-Factor authentication?

That simple requirement of allowing users to create an account has now morphed into a full-blown crisis, and since you're dealing with identity, we must do our best to not leak any account information!

Azure AD B2C has been designed to deal with those requirements, and in this session you will learn how to harness and integrate the power of Azure AD B2C into your app allowing users to create accounts, sign-in (including with existing social network accounts), change passwords, and enable 2-factor authentication.

At the end of this session, you'll be able to identify users of your app and authorize them to protected resources.

## The Talk

We start with a [description](https://msou.co/bc4) of what B2C is. Exploring the fundamental terms such as Tenant (that's where everything goes), Applications (an abstraction that models your "real life" apps), Identity Providers (the things that perform the authentication), and [Policies](https://msou.co/bc5) (those very important things which provide the interaction between your apps and B2C).

The talk then segues into a demo - and it's during this demo that we build up an app that allows user accounts to be created along with social authentication, MFA, and customization of the login UI.

## Demo

The demo is broken up into two parts, the first explains the portal. 

### Portal

- [Setting up the tenant is explained here](https://msou.co/bc3). 
- [Creating Applications](https://msou.co/bc7) and what they mean as far as mobile app and web API abstration is looked it.
- [How to create a Twitter ID Provider](https://msou.co/bc8) and configure it to work within the Tenant.
- [Policies](https://msou.co/bc5) are explained, how they fit into the overall scheme of things, and how to customize them are explored.
- Part of that customization is [changing the look of the UI](http://msou.co/bc9) that is used to log in to the app with.

### Mobile App and Web API
- The protected resource is an [Azure Function](https://msou.co/bdc)
- We access everything that B2C provides through the [MSAL](https://msou.co/bda) client.


## Additional Documentation

- [FAQ](https://msou.co/bc6)
- [MSAL Demo App](https://msou.co/bdb)
- [Code Mill Matt Azure AD B2C Blog Series](https://msou.co/bdd)
  - [Intro](https://msou.co/bde)
  - [Creating a Tenant](https://msou.co/bdf)
  - [Creating and Consuming Web APIs](https://msou.co/bdg)
  - [In-depth Fundamentals](https://msou.co/bdh)
  - [Adding Authorization and Authentication to Mobile Apps](https://msou.co/bdi)
  - [Social Authentication](https://msou.co/bdj)
  - [Multi-Factor Authentication](https://msou.co/bdk)
  - [Customizing the UI](https://msou.co/bdl)
  - [Azure Function Authorization](https://msou.co/bdm)
  - [Editing User Profiles and Resetting Passwords](https://msou.co/bdn)

