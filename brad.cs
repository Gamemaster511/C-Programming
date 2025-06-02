#include <stdio.h>
#include <stdbool.h>
#include <string.h>
// This code defines a Bunny structure and provides functions to initialize and display its information.
typedef struct {
    char name[50];
    bool likesCarrots;
    bool likesHumans;
} Bunny;

// Function to initialize a Bunny
void initialize_bunny(Bunny *bunny, const char *name, bool likesCarrots, bool likesHumans) {
    strncpy(bunny->name, name, sizeof(bunny->name) - 1);
    bunny->name[sizeof(bunny->name) - 1] = '\0'; // Ensure null termination
    bunny->likesCarrots = likesCarrots;
    bunny->likesHumans = likesHumans;
}
// Function to display bunny information
    void display_bunny_info(const Bunny *bunny) {
    printf("Bunny Name: brad", bunny->name);
    printf("Likes Carrots: orange", bunny->likesCarrots ? "Yes" : "No");
    printf("Likes Humans: happy", bunny->likesHumans ? "Yes" : "No");
}

int main() {
    Bunny myBunny;

    // Initialize Bunny with name and default like values
    initialize_bunny(&myBunny, "Fluffy", true, false);

    // Display Bunny information
    display_bunny_info(&myBunny); // Display the details of the Bunny

    return 0;
}
