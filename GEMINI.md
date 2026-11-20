# `how-long-ago-common` (`HowCommon`) — Context & Rules

## Overview
Shared .NET 8 class library packaged as `HowCommon` and consumed by `how-long-ago` and `how-long-ago-identity`.
Provides `CertificateManagerBase`, `UserIdHelper`, `IdentityRoleConstant`, `MicroServicesEnum`, `StringExtensions.ToSnake()`, and MassTransit contracts (`UserRegisterMessage`, `UserRegiserBulkMessage`, `UserRegiserBulkResponseMessage`, `UserDeletedMessage`, `UserSuspendedStateMessage`).

## Rules
- Maintain backward compatibility on MassTransit message contract namespaces and properties as they are serialized across RabbitMQ between `HowIdentity` and `How.Server`.
- Note the order of arguments in `ArgumentException.ThrowIfNullOrEmpty(argument, paramName)`.
