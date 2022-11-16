/*
https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

*/
public class Solution {
    public int StrStr(string haystack, string needle) {
        return haystack.IndexOf(needle);        
    }
}