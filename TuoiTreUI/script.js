const API_KEY = "04287698edae429385a5b7e2b3bee7e8";
const url = "https://newsapi.org/v2/everything?q=";

window.addEventListener("load", () => fetchNews("Anime"));

async function fetchNews(query) {
  const res = await fetch(`${url}${query}&apiKey=${API_KEY}`);
  // bindData(data.articles);
  const data = await res.json();
  console.log(data.articles);
  generateNewsItems(data.articles);
  generateNewsItemsTwo(data.articles);
  generateNewsItemsThree(data.articles);
  generateNewsItemsFour(data.articles);
}

// Function to generate news items
function generateNewsItems(articles) {
  const container = document.getElementById('main-content'); // Get the main container
  var idx = 0;
  for (let i = 0; i < articles.length; i++) {
    if (idx > 10) break;
    const article = articles[i];

    if (article.urlToImage === null || article.urlToImage === "") continue;

    const newsItem = document.createElement('div');
    newsItem.className = 'news-item-small';

    // Create image element
    const image = document.createElement('img');
    image.src = article.urlToImage; // Use urlToImage from the article
    image.alt = "News Image"; // Alt text for the image
    newsItem.appendChild(image);

    // Create a div for the text content
    const textDiv = document.createElement('div');

    // Create title element
    const title = document.createElement('h3');
    title.innerHTML = article.title; // Use title from the article
    textDiv.appendChild(title);

    // Create description element
    const description = document.createElement('p');
    description.innerHTML = article.description; // Use description from the article
    textDiv.appendChild(description);

    const sourceElement = generateSourceContainer();
    textDiv.appendChild(sourceElement);

    // Append the text div to the news item
    newsItem.appendChild(textDiv);

    // Append the news item to the container
    container.appendChild(newsItem);
    idx++;
  }
}

function generateNewsItemsTwo(articles) {
  const container = document.getElementById('main-content-2'); // Get the main container
  var idx = 0;
  for (let i = 0; i < articles.length; i++) {
    if (idx > 7) break;
    const article = articles[i];

    if (article.urlToImage === null || article.urlToImage === "") continue;

    const newsItem = document.createElement('div');
    newsItem.className = 'news-item-small';

    // Create image element
    const image = document.createElement('img');
    image.src = article.urlToImage; // Use urlToImage from the article
    image.alt = "News Image"; // Alt text for the image
    newsItem.appendChild(image);

    // Create a div for the text content
    const textDiv = document.createElement('div');

    // Create title element
    const title = document.createElement('h3');
    title.innerHTML = article.title; // Use title from the article
    textDiv.appendChild(title);

    const sourceElement = generateSourceContainer();
    textDiv.appendChild(sourceElement);

    // Append the text div to the news item
    newsItem.appendChild(textDiv);

    // Append the news item to the container
    container.appendChild(newsItem);
    idx++;
  }
}

function generateNewsItemsThree(articles) {
  const container = document.getElementById('main-content-3'); // Get the main container
  for (let i = 0; i < articles.length; i++) {
    if (i > 3) break;
    const article = articles[i];

    if (article.urlToImage === null || article.urlToImage === "") continue;

    const newsItem = document.createElement('div');
    newsItem.className = 'news-item-small';

    // Create image element
    const image = document.createElement('img');
    image.src = article.urlToImage; // Use urlToImage from the article
    image.alt = "News Image"; // Alt text for the image
    newsItem.appendChild(image);

    // Create a div for the text content
    const textDiv = document.createElement('div');

    // Create title element
    const title = document.createElement('h3');
    title.innerHTML = article.title; // Use title from the article
    textDiv.appendChild(title);

    const sourceElement = generateSourceContainer();
    textDiv.appendChild(sourceElement);

    // Append the text div to the news item
    newsItem.appendChild(textDiv);

    // Append the news item to the container
    container.appendChild(newsItem);
  }
}

function generateNewsItemsFour(articles) {
  const container = document.getElementById('horizontal-lst'); // Get the main container
  var idx = 0;
  for (let i = articles.length - 6; i >= 0; i--) {
    if (idx > 3) break;
    const article = articles[i];
    console.log(article);

    if (article.urlToImage === null || article.urlToImage === "") continue;

    const newsItem = document.createElement('div');
    newsItem.className = 'vertical-item';

    // Create image element
    const image = document.createElement('img');
    image.src = article.urlToImage; 
    image.height = 100;
    image.style.borderRadius = 4;
    image.style.width = 50;// Use urlToImage from the article
    image.alt = "News Image"; // Alt text for the image
    newsItem.appendChild(image);

    // Create title element
    const title = document.createElement('h5');
    title.innerHTML = article.title; // Use title from the article
    newsItem.appendChild(title);

    const sourceElement = generateSourceContainer();
    newsItem.appendChild(sourceElement);

    // Append the text div to the news item
    // Append the news item to the container
    container.appendChild(newsItem);
    idx++;
  }
}

// Function to generate the specific HTML structure
function generateSourceContainer() {
  // Create the main div
  const sourceContainer = document.createElement('div');
  sourceContainer.style.width = '150px';
  sourceContainer.style.height = '35px';
  sourceContainer.style.display = 'flex';
  sourceContainer.style.gap = '4px';
  sourceContainer.style.alignItems = 'center';
  sourceContainer.style.verticalAlign = 'middle';

  // Create the image element
  // const logoImage = document.createElement('img');
  // logoImage.src = 'images/tuoitrelogo.png'; // Replace with the actual logo URL
  // logoImage.style.width = 'auto'; // Set the width
  // logoImage.style.height = '10px'; // Set the height
  // logoImage.style.cssText = 'display:inline !important';

  // Create the span element for time
  const timeSpan = document.createElement('span');
  timeSpan.style.width = '100px'; // Set the width
  timeSpan.style.fontSize = '10px'; // Set the font size
  timeSpan.style.color = 'gray'; // Set the text color
  timeSpan.innerHTML = '41 phút'; // Set the time text

  // Append the image and span to the main div
  // sourceContainer.appendChild(logoImage);
  sourceContainer.appendChild(timeSpan);

  return sourceContainer; // Return the generated div
}


