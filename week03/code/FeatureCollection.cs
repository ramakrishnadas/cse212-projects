using System.Reflection.Metadata;

public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE

    // Create a List of Feature objects
    public List<Feature> Features { get; set; }

    // Create additional classes as necessary

    // Create Feature class that contains the properties of each feature
    public class Feature 
    {
        public Properties Properties { get; set; }
    }

    // Create Properties class that contains the place and magnitude of each feature
    public class Properties 
    {
        public string Place { get; set; }
        public float Mag { get; set; }
    }
}