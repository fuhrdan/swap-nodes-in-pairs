//*****************************************************************************
//** 24. Swap Nodes in Pairs    leetcode                                     **
//*****************************************************************************


/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     struct ListNode *next;
 * };
 */
struct ListNode* swapPairs(struct ListNode* head) {
    // Create a dummy node to handle edge cases (e.g. empty list)
    struct ListNode dummy;
    dummy.val = 0;
    dummy.next = head;

    // Initialize pointers
    struct ListNode* prev = &dummy;
    struct ListNode* curr = head;

    // Iterate through the list in pairs
    while (curr != NULL && curr->next != NULL) {
        // Save pointers
        struct ListNode* nxtPair = curr->next->next;
        struct ListNode* second = curr->next;

        // Reverse the current pair
        second->next = curr;
        curr->next = nxtPair;
        prev->next = second;

        // Update pointers
        prev = curr;
        curr = nxtPair;
    }

    // Return the new head of the list
    return dummy.next;
}