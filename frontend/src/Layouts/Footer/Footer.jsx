import React, { useEffect, useState } from "react";
import { Button } from "@mui/material";
import "./footer.css";
import "./footerMobile.css";
import TwitterService from "../../Services/TwitterService";
import image from "../../img/image.js";
import TextField from "@mui/material/TextField";

export default function Footer() {
  const [Twitter, setTwitter] = useState([]);

  useEffect(() => {
    let twitterService = new TwitterService();
    twitterService
      .getTwitterInfo()
      .then((result) => setTwitter(result.data.data));
  });

  return (
    <div className="footer-main">
      <div className="about">
        <h3>Hakkımızda</h3>
        <p>At half-past eight the door opened, the policeman appeared.</p>

        <TextField
          id="outlined-password-input"
          label="E-mail"
          className="coustom-text"
        />
        <Button>Abone ol</Button>
      </div>
      <div className="twitter">
        <h3>Son Tweetler</h3>
        <ul>
          {Twitter.map((twitter) => (
            <li>
              <p>{twitter.tweet}</p>
            </li>
          ))}
        </ul>
      </div>
      <div className="instegram">
        <h3>instagram</h3>
        <ul>
          <li>
            <img src={image.BasePicture2} alt="image" />
          </li>
          <li>
            <img src={image.BasePicture2} alt="image" />
          </li>
          <li>
            <img src={image.BasePicture2} alt="image" />
          </li>
          <li>
            <img src={image.BasePicture2} alt="image" />
          </li>
          <li>
            <img src={image.BasePicture2} alt="image" />
          </li>
          <li>
            <img src={image.BasePicture2} alt="image" />
          </li>
        </ul>
      </div>
    </div>
  );
}
