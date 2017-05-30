package com.example.prabath.onlinequiz;

/**
 * Created by Prabath on 5/27/2017.
 */

public class QuestionLibrary {
    private String mQuestions[] = {
            "2+2*2+2 = __ ?",
            "Twincle twincle ____ ____",
            "Population of Sri Lanka ?",
            "What is the longest river..?"
    };

    private String mChoice[][] = {
            {"16","10","8"},
            {"twinclw twincle","little star","little moon"},
            {"1 Million","2 Million","2 Billion"},
            {"Nile","Amazon","Victoria"}
    };

    private String mCorrectAnswers[] = {"8","little star","2 Million","Nile"};

    public String getQuestion(int a){
        String question = mQuestions[a];
                return question;
    }

    public String getChoice1(int a){
        String choice0 = mChoice[a][0];
        return choice0;
    };

    public String getChoice2(int a){
        String choice1 = mChoice[a][1];
        return choice1;
    };

    public String getChoice3(int a){
        String choice2 = mChoice[a][2];
        return choice2;
    };

    public String getCorrectAnswer(int a) {
        String answer = mCorrectAnswers[a];
        return answer;
    };




}
