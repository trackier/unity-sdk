#import <Foundation/Foundation.h>
#import "unityswift-Swift.h"    // Required
// This header file is generated automatically when Xcode build runs.

extern "C" {
    void Start(const char *message) {
        // You can access Swift classes directly here.
        [TrackierIOS initializeSDK:[NSString stringWithUTF8String:message]];
    }
}