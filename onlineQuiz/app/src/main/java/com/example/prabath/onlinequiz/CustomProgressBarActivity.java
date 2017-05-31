package com.example.prabath.onlinequiz;

import android.content.Intent;
import android.os.Bundle;
import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.widget.ProgressBar;
import android.widget.TextView;


/*


public class CustomProgressBarActivity extends AppCompatActivity {

        private TextView txtProgress;
        private ProgressBar progressBar;
        private int pStatus = 0;
        private Handler handler = new Handler();

        @Override
        protected void onCreate(Bundle savedInstanceState) {
            super.onCreate(savedInstanceState);
            setContentView(R.layout.activity_custom_progressbar);

            txtProgress = (TextView) findViewById(R.id.txtProgress);
            progressBar = (ProgressBar) findViewById(R.id.progressBar);

            new Thread(new Runnable() {
                @Override
                public void run() {
                    while (pStatus <= 100) {
                        handler.post(new Runnable() {
                            @Override
                            public void run() {
                                progressBar.setProgress(pStatus);
                                txtProgress.setText(pStatus + " %");
                            }
                        });
                        try {
                            Thread.sleep(100);
                        } catch (InterruptedException e) {
                            e.printStackTrace();
                        }

                      
                        pStatus++;
                    }

                        Intent openStart=new Intent("com.example.prabath.progressbar.START");
                        startActivity(openStart);


                }
            }).start();

        }
    protected void onPause() {
        super.onPause();
        finish();
    }

    }

