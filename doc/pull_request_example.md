# Summary
---
- Date: 2021/10/23
- Author: Someone
- Reviewer: Someone Else
- Subject Password reset support
- Label: pull_request_example

# What
---
Added password reset support. It included UI changes, new API endpoints, and DB schema changes. See ticket #L-123 for details.

# Why
---
We need it to complete the user auth epic #E-123.

# How
---
Password reset implementation. On user's request it sends an email with a one-time-use URL to reset the password. See ticket #L-123  for details.

When testing locally, ryn the migration and re-install server dependencies.

## Changes details
- Added new migration file `1.0.1-password-reset.sql` that creates a new table `password-reset-code`.
- Added new dependency to the server: `uuid-short`.
- Added `/auth/reset-password` and `/auth/confirm-password` endpoints to the server.
- Added `PasswordResetController` that calls the `/auth/reset-password` and `/auth/confirm-password` endpoints.
- Update `LoginView` to include a password reset button.
- Added a new page for password reset initiation `PasswordResetView`
- Added a new page for password creation `NewPasswordView`



# Missed anything ?
---
- [x] Explained the purpose of this PR.
- [x] Self reviewed the PR.
- [x] Added or updated test cases.
- [ ] Informed of breaking changes, testing and migrations (if applicable).
- [ ] Updated documentation (if applicable).
- [ ] Attached screenshots (if applicable).