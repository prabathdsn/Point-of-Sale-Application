package com.example.prabath.onlinequiz;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.widget.Button;
import android.widget.TextView;

/**
 * Created by Prabath on 5/30/2017.
 */

public class end extends AppCompatActivity {
    private firstScrn score = new firstScrn();
    private Button quit;
    private TextView mScoreView;
    public int x;
    public String text;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.exit);


        quit=(Button) findViewById(R.id.quit);
        mScoreView = (TextView) findViewById(R.id.Score_text);


        Bundle bundle = getIntent().getExtras();
        text= bundle.getString("s");
        mScoreView.setText("Your  Score is: "+text);



    }







}
