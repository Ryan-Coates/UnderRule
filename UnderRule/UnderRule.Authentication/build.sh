echo "building image..."
docker build -t underrule.authentication .

echo "tagging image..."
docker tag underrule.authentication1 hellcaller89/underrule.authentication:latest 
docker tag underrule.authentication1 hellcaller89/underrule.authentication:v0.04

echo "Pushing image..."
docker push hellcaller89/underrule.authentication:latest
docker push hellcaller89/underrule.authentication:v0.04