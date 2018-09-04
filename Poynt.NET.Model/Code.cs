//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public enum Code
    {

        //    STORE_DEVICE_ALREADY_REGISTERED(400, "Store device already registered with a different store."),
        //    STORE_DEVICE_ALREADY_ACTIVATED(400, "Store device already activated."),
        //    STORE_DEVICE_UNVERIFIED(400, "Store device failed verification."),
        //    BUSINESS_ALREADY_EXISTS(400, "The business already registered in our system."),
        //    CREDENTIAL_ALREADY_EXISTS(400, "The credential already exists."),
        //    CARD_ALREADY_EXISTS(400, "The card already exists."),
        //    BAD_CARD_DATA(400, "The card data provided is invalid or incomplete."),
        //    TXN_ALREADY_CAPTURED(400, "The transaction has already been captured."),
        //    CAPTURE_NOT_ALLOWED(400, "The transaction can't be captured."),
        //    TXN_ALREADY_REFUNDED(400, "The transaction has already been refunded."),
        //    TXN_ALREADY_VOIDED(400, "The transaction has already been voided."),
        //    DEVICE_ALREADY_PRESENT(400, "The device is already present."),
        //    ORDER_UUID_ALREADY_EXISTS(400, "The Order UUID already exists and is too old."),
        //    REQUEST_ID_DUPLICATE(400, "The Poynt-Request-Id has already been processed."),
        //    REQUEST_IN_PROGRESS(400, "The Poynt-Request-Id is currently being processed."),
        //    ORDER_ALREADY_COMPLETED(400, "The Order has already been marked as completed."),
        //    TXN_DUPLICATE(400, "We have detected a transaction that might be duplicate."),
        //    TXN_ALREADY_EXISTS(400, "The transaction already exists."),
        //    DATABASE_ERROR(500, "System error."),
        //    INTERNAL_ERROR(500, "System error."),
        //    ATLEAST_ONE_TXN_FAILED(400, "Order cancelled as at least one of the transactions failed."),
        //    /** @deprecated */
        //    @Deprecated
        //PROCESSOR_DECLINED(400, "Processor declined."),
        //    /** @deprecated */
        //    @Deprecated
        //PROCESSOR_TIMEOUT(400, "Processor call timed out. A request to cancel this has already been issued."),
        //    PROCESSOR_DETECTED_DUP(400, "Processor detected duplicate txn. If this is not duplicate, please retry after 6 minutes."),
        //    PROCESSOR_SIGNON_FAILED(500, "Processor sign-on failed; typically retriable."),
        //    EXTERNAL_SERVER_CONNECT_FAILURE(500, "Could not connect to external server."),
        //    EXTERNAL_SERVER_READ_TIMEOUT(500, "Call to external server timed out. If this was payments related operation, a request to cancel this has already been issued."),
        //    EXTERNAL_SERVER_ERROR(500, "Unknown error from the server."),
        //    MISSING_PARAMETER(400, "Required parameter is missing."),
        //    STORE_DEVICE_NOT_FOUND(404, "Store device not found in our records."),
        //    BUSINESS_AGREEMENT_NOT_FOUND(404, "Business agreement not found in our records."),
        //    BUSINESS_NOT_FOUND(404, "Business not found in our records."),
        //    BUSINESS_NOT_SETUP(400, "Business is not fully setup."),
        //    ACQUIRER_NOT_SETUP(400, "Acquirer is not fully setup."),
        //    CARD_NOT_FOUND(404, "Card not found in our records."),
        //    ORDER_NOT_FOUND(404, "Order not found"),
        //    CUSTOMER_NOT_FOUND(404, "Customer not found in our records."),
        //    MULTIPLE_CARDS_MATCHING_PAN(400, "Multiple card found matching PAN."),
        //    TXN_NEVER_PROCESSED(400, "Transaction processing was started but never completed"),
        //    APPLICATION_NOT_FOUND(404, "Application not found in our records."),
        //    TRANSACTION_NOT_FOUND(404, "Transaction not found"),
        //    KEY_NOT_FOUND(404, "Key not found"),
        //    CAPTURE_EXCEEDS_PREAUTH_BAL(400, "Capture total exceeds pre-auth balance on card"),
        //    INVALID_PARAMETER(400, "Parameter provided is invalid."),
        //    CANCEL_UNSUPPORTED_ON_MODIFIED_ORDER(400, "Order cancel currently not supported on orders that have been modified"),
        //    INVALID_URL_PATTERN(404, "Url pattern is invalid."),
        //    LOGIN_FAILED(401, "Login failed."),
        //    UNSUPPORTED_TXN_TYPE(400, "Transaction type is unsupported."),
        //    UNSUPPORTED_TXN_ACTION(400, "Transaction action is unsupported."),
        //    INVALID_ACCESS_TOKEN(401, "Access token is missing or invalid."),
        //    INVALID_REFRESH_TOKEN(401, "Refresh token is missing or invalid."),
        //    INVALID_REQUEST(400, "Bad request."),
        //    UNAUTHORIZED_ACCESS(401, "Access not authorized for the requested resource."),
        //    INVALID_RESOURCE_ID(404, "The requested resource does not exist."),
        //    ITEM_NOT_FULFILLED_OR_RETURNED(400, "Order should probably not be completed as there are items that are neither fulfilled, nor returned."),
        //    ORDER_TXN_RECON_FAILED(400, "Order should probably not be completed as funds received do not match with funds expected for this order."),
        //    RESOURCE_MODIFIED(409, "The resource was modified. Please re-get the resource before proceeding."),
        //    RESOURCE_NOT_FOUND(404, "Cannot find the resource."),
        //    WEBHOOK_UNDELIVERABLE(400, "Cannot deliver the web hook."),
        //    BROKEN_PIPE(499, "The client closed the connection before response transmission finished."),
        //    UNSUPPORTED_OPERATION(400, "The operation is not supported."),
        //    STORE_DEVICE_NOT_ACTIVATED(403, "Store device has not been activated."),
        //    APPLICATION_NOT_ACTIVATED(403, "Application has not been activated."),
        //    RKMS_UNAVAILABLE(503, "Failed to communicate with the RKMS service."),
        //    SERVICE_UNAVAILABLE(504, "Failed to communicate with the upstream service.");

        //"Store device already registered with a different store."       
        STORE_DEVICE_ALREADY_REGISTERED,
        //"Store device already activated."
        STORE_DEVICE_ALREADY_ACTIVATED ,
        // "Store device failed verification."
        STORE_DEVICE_UNVERIFIED ,
        // "The business already registered in our system."
        BUSINESS_ALREADY_EXISTS ,
        // "The credential already exists."
        CREDENTIAL_ALREADY_EXISTS,
        // "The card already exists."
        CARD_ALREADY_EXISTS,
        // "The card data provided is invalid or incomplete."
        BAD_CARD_DATA , 
        TXN_ALREADY_CAPTURED,
        CAPTURE_NOT_ALLOWED,
        TXN_ALREADY_REFUNDED,
        TXN_ALREADY_VOIDED,
        DEVICE_ALREADY_PRESENT,
        ORDER_UUID_ALREADY_EXISTS,
        REQUEST_ID_DUPLICATE,
        REQUEST_IN_PROGRESS,
        ORDER_ALREADY_COMPLETED,
        TXN_DUPLICATE,
        TXN_ALREADY_EXISTS,
        DATABASE_ERROR,
        INTERNAL_ERROR,
        ATLEAST_ONE_TXN_FAILED,
        /** @deprecated */
        //@Deprecated
    PROCESSOR_DECLINED,
        /** @deprecated */
        //@Deprecated
    PROCESSOR_TIMEOUT,
        PROCESSOR_DETECTED_DUP,
        PROCESSOR_SIGNON_FAILED,
        EXTERNAL_SERVER_CONNECT_FAILURE,
        EXTERNAL_SERVER_READ_TIMEOUT,
        EXTERNAL_SERVER_ERROR,
        MISSING_PARAMETER,
        STORE_DEVICE_NOT_FOUND,
        BUSINESS_AGREEMENT_NOT_FOUND,
        BUSINESS_NOT_FOUND,
        BUSINESS_NOT_SETUP,
        ACQUIRER_NOT_SETUP,
        CARD_NOT_FOUND,
        ORDER_NOT_FOUND,
        CUSTOMER_NOT_FOUND,
        MULTIPLE_CARDS_MATCHING_PAN,
        TXN_NEVER_PROCESSED,
        APPLICATION_NOT_FOUND,
        TRANSACTION_NOT_FOUND,
        KEY_NOT_FOUND,
        CAPTURE_EXCEEDS_PREAUTH_BAL,
        INVALID_PARAMETER,
        CANCEL_UNSUPPORTED_ON_MODIFIED_ORDER,
        INVALID_URL_PATTERN,
        LOGIN_FAILED,
        UNSUPPORTED_TXN_TYPE,
        UNSUPPORTED_TXN_ACTION,
        INVALID_ACCESS_TOKEN,
        INVALID_REFRESH_TOKEN,
        INVALID_REQUEST,
        UNAUTHORIZED_ACCESS,
        INVALID_RESOURCE_ID,
        ITEM_NOT_FULFILLED_OR_RETURNED,
        ORDER_TXN_RECON_FAILED,
        RESOURCE_MODIFIED,
        RESOURCE_NOT_FOUND,
        WEBHOOK_UNDELIVERABLE,
        BROKEN_PIPE,
        UNSUPPORTED_OPERATION,
        STORE_DEVICE_NOT_ACTIVATED,
        APPLICATION_NOT_ACTIVATED,
        RKMS_UNAVAILABLE,
        SERVICE_UNAVAILABLE

    }
}