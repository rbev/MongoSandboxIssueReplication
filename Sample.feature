

Feature: Deadlock
    Scenario: Deadlock should not happen
        When specflow starts a MongoSandbox
        Then the MongoSandbox is started
